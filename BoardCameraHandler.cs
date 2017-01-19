using System;
using System.Text;
using Ozeki.Camera;
using Ozeki.Media;
using System.Drawing;

namespace CameraCTRL
{
    class BoardCameraHandler
    {
        private MediaConnector Connector;

        public IWebCamera Camera { get; private set; }
        public DrawingImageProvider ImageProvider { get; private set; }

        public event EventHandler<CameraStateEventArgs> CameraStateChanged;

        private ImageMask _imageMask;
        private Bitmap bmpImg;
        private Graphics grfx;

        public BoardCameraHandler()
        {
            ImageProvider = new DrawingImageProvider();            
            Connector = new MediaConnector();

            _imageMask = new ImageMask();
            _imageMask.MaskColor = Color.Black;
            _imageMask.Difference = 100;
            _imageMask.MaskOption = MaskOption.Foreground;

            bmpImg = new Bitmap(180, 135);
            bmpImg.SetResolution(100, 100);

            grfx = Graphics.FromImage(bmpImg);
        }

        public void ConnectCamera(string cameraUrl)
        {
            if (Camera != null)
                CloseCamera();
                        
            Camera = new OzekiCamera(cameraUrl);

            if (Camera == null) return;            

            Connector.Connect(Camera.VideoChannel, _imageMask);
            Connector.Connect(_imageMask, ImageProvider);

            Camera.CameraStateChanged += Camera_CameraStateChanged;

            Camera.Start();
            _imageMask.Start();
        }

        private void Camera_CameraStateChanged(object sender, CameraStateEventArgs e)
        {
            // signal to GUI
            var handler = CameraStateChanged;
            if (handler != null)
                handler(this, e);
        }

        public void Disconnect()
        {
            CloseCamera();
        }

        private void CloseCamera()
        {
            if (Camera == null)
                return;

            _imageMask.Stop();

            Camera.Stop();
            Connector.Disconnect(Camera.VideoChannel, ImageProvider);
            Camera = null;
        }

        public void drawRec(System.Drawing.Rectangle _rect)
        {
            grfx.Clear(Color.Black);
            grfx.DrawRectangle(new Pen(Color.Red, 2), _rect);
            _imageMask.Image = bmpImg;
        }
    }
}