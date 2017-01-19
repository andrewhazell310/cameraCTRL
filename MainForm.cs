using System;
using System.Linq;
using System.Windows.Forms;

using Ozeki.Camera;
using Ozeki.Media;

using CameraCTRL.LOG;
using System.Diagnostics;
using System.Globalization;
using System.Drawing;
using System.ComponentModel;
using System.Threading;

namespace CameraCTRL
{
    public partial class MainForm : Form
    {
        private IpCameraHandler ipCamera;
        private BoardCameraHandler boardCamera;

        private CameraURLBuilderWF _myCameraUrlBuilder;
        private CameraURLBuilderWF boardCameraUrlBuilder;

        
        public MainForm()
        {
            InitializeComponent();
            Log.OnLogMessageReceived += Log_OnLogMessageReceived;   
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ipCamera = new IpCameraHandler();
            ipCamera.CameraStateChanged += IpCameraStateChanged;
            ipCamera.CameraErrorOccured += IpCameraErrorOccured;

            _myCameraUrlBuilder = new CameraURLBuilderWF();                      

            videoViewerWF1.SetImageProvider(ipCamera.ImageProvider);            

            comboBox_Direction.DataSource = Enum.GetValues(typeof(PatrolDirection));

            boardCamera = new BoardCameraHandler();
            boardCamera.CameraStateChanged += BoardCameraStateChanged;

            boardCameraUrlBuilder = new CameraURLBuilderWF(new CameraURLBuilderData { DeviceTypeFilter = DiscoverDeviceType.USB });

            videoViewerWF2.SetImageProvider(boardCamera.ImageProvider);
        }

        
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ipCamera.Stop();
        }

        private void IpCameraStateChanged(object sender, CameraStateEventArgs e)
        {
            InvokeGuiThread(() =>
            {
                Log.Write("Camera state: " + e.State);

                switch (e.State)
                {
                    // The list of streams become available at the Streaming state.
                    case CameraState.Streaming:

                        button_Connect.Enabled = false;

                        videoViewerWF1.Start();
                        ClearFields();
                        GetCameraStreams();

                        button_Disconnect.Enabled = true;
                                                
                        break;

                    case CameraState.Disconnected:
                        button_Disconnect.Enabled = false;
                        videoViewerWF1.Stop();
                        button_Connect.Enabled = true;
                        break;
                }
            });
        }

        private void BoardCameraStateChanged(object sender, CameraStateEventArgs e)
        {
            InvokeGuiThread(() =>
            {
                Log.Write("Camera state: " + e.State);

                switch (e.State)
                {
                    // The list of streams become available at the Streaming state.
                    case CameraState.Streaming:

                        button1.Enabled = false;
                        videoViewerWF2.Start();
                        button2.Enabled = true;

                        break;

                    case CameraState.Disconnected:
                        button2.Enabled = false;
                        videoViewerWF2.Stop();
                        button1.Enabled = true;
                        break;
                }
            });
        }        

        private void GetCameraStreams()
        {
            if (ipCamera.Camera.AvailableStreams.Any())
            {
                var selected = 0;
                InvokeGuiThread(() =>
                {
                    for (var index = 0; index < ipCamera.Camera.AvailableStreams.Count(); index++)
                    {

                        if (ipCamera.Camera.CurrentStream.Name == ipCamera.Camera.AvailableStreams[index].Name)
                        {
                            selected = index;
                        }
                        StreamCombo.Items.Add(ipCamera.Camera.AvailableStreams[index].Name +
                                                " " +
                                                ipCamera.Camera.AvailableStreams[index].VideoEncoding
                                                    .Resolution);
                    }
                    StreamCombo.SelectedIndex = selected;

                });
            }
        }

        private void IpCameraErrorOccured(object sender, CameraErrorEventArgs e)
        {
            InvokeGuiThread(() => Log.Write("Camera error: " + (e.Details ?? e.Error.ToString())));
        }
        
        #region Connect - Disconnect

        private void button_Connect_Click(object sender, EventArgs e)
        {
            ClearFields();
            // ONVIF
            if (tb_cameraUrl.Text.ToUpper().Trim().StartsWith("RTSP://"))
                Log.Write("Connecting to a stream of ONVIF device by RTSP");
            else if (tb_cameraUrl.Text.ToUpper().Trim().StartsWith("HTTP://"))
                Log.Write("Connecting to ONVIF device by HTTP");
            else if (tb_cameraUrl.Text.ToUpper().Trim().StartsWith("USB://"))
                Log.Write("Connecting to an USB device");
            ConnectIpCam();
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            if (ipCamera.Camera != null)
                ipCamera.Disconnect();

            ClearFields();
        }

        private void ConnectIpCam()
        {
            ipCamera.ConnectOnvifCamera(_myCameraUrlBuilder.CameraURL);
            videoViewerWF1.Start();
        }

        #endregion

        #region LOG

        void Log_OnLogMessageReceived(object sender, LogEventArgs e)
        {
            InvokeGuiThread(() =>
            {
                logListBox.Items.Add(e.LogMessage);
                LogScroll();
            });
        }

        void LogScroll()
        {
            logListBox.SelectedIndex = logListBox.Items.Count - 1;
            logListBox.SelectedIndex = -1;
        }

        #endregion

        private void ClearFields()
        {
            InvokeGuiThread(() =>
            {
                StreamCombo.Items.Clear();
                StreamCombo.Text = String.Empty;
            });
        }

        #region Stream select

        private void StreamCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            if (combo == null || combo.SelectedIndex == -1) return;

            var CurrentStream = ipCamera.Camera.AvailableStreams[StreamCombo.SelectedIndex];
            if (CurrentStream == null) throw new ArgumentNullException("Stream");
            Log.Write("Camera changed stream to " + CurrentStream.Name);

            ipCamera.Camera.Start(CurrentStream);            
        }
        #endregion

        
        private void InvokeGuiThread(Action action)
        {
            BeginInvoke(action);
        }
                
        private void MouseDownMove(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            if (button != null) ipCamera.Move(button.Text);
        }

        private void MouseUpMove(object sender, MouseEventArgs e)
        {
            if (ipCamera.Camera == null) return;
            ipCamera.Camera.CameraMovement.StopMovement();
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            if (ipCamera.Camera == null) return;
            ipCamera.Camera.CameraMovement.GoToHome();
        }

        private void button_SetHome_Click(object sender, EventArgs e)
        {
            if (ipCamera.Camera == null) return;
            ipCamera.Camera.CameraMovement.SetHome();
        }        

        private void button_ScanStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox_Duration.Text)) return;
                var patrol = (PatrolDirection)comboBox_Direction.SelectedItem;
                var duration = double.Parse(textBox_Duration.Text);
                ipCamera.Camera.CameraMovement.Patrol(patrol, duration);
            }
            catch (Exception exception)
            {
                Log.Write(exception.Message);
            }
        }

        private void button_ScanStop_Click(object sender, EventArgs e)
        {
            if (ipCamera.Camera == null) return;
            ipCamera.Camera.CameraMovement.StopMovement();
        }

        private void btn_compose_Click(object sender, EventArgs e)
        {
            var result = _myCameraUrlBuilder.ShowDialog();

            if (result != DialogResult.OK) return;

            tb_cameraUrl.Text = _myCameraUrlBuilder.CameraURL;

            button_Connect.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectBoardCam();
        }

        private void ConnectBoardCam()
        {
            boardCamera.ConnectCamera(boardCameraUrlBuilder.CameraURL);
            videoViewerWF2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = boardCameraUrlBuilder.ShowDialog();

            if (result != DialogResult.OK)
                return;

            textBox1.Text = boardCameraUrlBuilder.CameraURL;

            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (boardCamera.Camera != null)
                boardCamera.Disconnect();
        }



        private bool _canDraw;
        private int _startX, _startY;
        private System.Drawing.Rectangle _rect;

        private void videoViewerWF2_MouseDown(object sender, MouseEventArgs e)
        {
            _canDraw = true;
            _startX = e.X;
            _startY = e.Y;
        }

        private void videoViewerWF2_MouseUp(object sender, MouseEventArgs e)
        {
            _canDraw = false;
        }

        private void videoViewerWF2_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_canDraw) return;

            int x = Math.Min(_startX, e.X);
            int y = Math.Min(_startY, e.Y);

            int width = Math.Max(_startX, e.X) - Math.Min(_startX, e.X);
            int height = Math.Max(_startY, e.Y) - Math.Min(_startY, e.Y);

            _rect = new System.Drawing.Rectangle(x, y, width, height);

            boardCamera.drawRec(_rect);            
        }
    }
    
}

