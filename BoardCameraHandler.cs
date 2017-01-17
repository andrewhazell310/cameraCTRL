using System;
using System.Text;
using Ozeki.Camera;
using Ozeki.Media;

namespace CameraCTRL
{
    class BoardCameraHandler
    {
        private MediaConnector Connector;

        public OzekiCamera Camera { get; private set; }
        public DrawingImageProvider ImageProvider { get; private set; }

        public event EventHandler<CameraStateEventArgs> CameraStateChanged;

        public BoardCameraHandler()
        {
            ImageProvider = new DrawingImageProvider();
            
            Connector = new MediaConnector();
            
        }

        public void ConnectCamera(string cameraUrl)
        {
            if (Camera != null)
                CloseCamera();

            // Gets the camera, which can be reached by the address, and requires authentication.
            Camera = new OzekiCamera(cameraUrl);

            if (Camera == null) return;
            Connector.Connect(Camera.VideoChannel, ImageProvider);

            Camera.CameraStateChanged += Camera_CameraStateChanged;

            Camera.Start();

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

            //Connector.Disconnect(Camera.VideoChannel, ImageProvider);
            //Camera.Disconnect();
            //Camera.Dispose();

            Camera.Stop();
            Connector.Disconnect(Camera.VideoChannel, ImageProvider);
            Camera = null;
        }
    }
}
