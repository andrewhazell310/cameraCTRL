using System;
using System.Text;
using Ozeki.Camera;
using Ozeki.Media;

namespace CameraCTRL
{
    class IpCameraHandler
    {
        private MediaConnector Connector;

        public OzekiCamera Camera { get; private set; }
        public DrawingImageProvider ImageProvider { get; private set; }

        public event EventHandler<CameraStateEventArgs> CameraStateChanged;
        public event EventHandler<CameraErrorEventArgs> CameraErrorOccured;

        public IpCameraHandler()
        {
            ImageProvider = new DrawingImageProvider();
            Connector = new MediaConnector();
        }

        public void ConnectOnvifCamera(string cameraUrl)
        {
            if (Camera != null)
                CloseCamera();

            // Gets the camera, which can be reached by the address, and requires authentication.
            Camera = new OzekiCamera(cameraUrl);

            if (Camera == null) return;
            Connector.Connect(Camera.VideoChannel, ImageProvider);

            Camera.CameraStateChanged += Camera_CameraStateChanged;
            Camera.CameraErrorOccurred += Camera_CameraErrorOccurred;

            Camera.Start();
        }

        private void Camera_CameraErrorOccurred(object sender, CameraErrorEventArgs e)
        {
            // signal to GUI
            var handler = CameraErrorOccured;
            if (handler != null)
                handler(this, e);
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

            Connector.Disconnect(Camera.VideoChannel, ImageProvider);
            Camera.Disconnect();
            Camera.Dispose();
        }

        public void Stop()
        {
            if (Camera != null)
            {
                Connector.Dispose();
                CloseCamera();
                ImageProvider.Dispose();
            }
        }

        public void Move(string direction)
        {
            if (Camera == null) return;
            switch (direction)
            {
                case "Up Left":
                    Camera.CameraMovement.ContinuousMove(MoveDirection.LeftUp);
                    break;
                case "Up":
                    Camera.CameraMovement.ContinuousMove(MoveDirection.Up);
                    break;
                case "Up Right":
                    Camera.CameraMovement.ContinuousMove(MoveDirection.RightUp);
                    break;
                case "Left":
                    Camera.CameraMovement.ContinuousMove(MoveDirection.Left);
                    break;
                case "Right":
                    Camera.CameraMovement.ContinuousMove(MoveDirection.Right);
                    break;
                case "Down Left":
                    Camera.CameraMovement.ContinuousMove(MoveDirection.LeftDown);
                    break;
                case "Down":
                    Camera.CameraMovement.ContinuousMove(MoveDirection.Down);
                    break;
                case "Down Right":
                    Camera.CameraMovement.ContinuousMove(MoveDirection.RightDown);
                    break;
                case "Set home":
                    Camera.CameraMovement.SetHome();
                    break;
                case "In":
                    Camera.CameraMovement.Zoom(MoveDirection.In);
                    break;
                case "Out":
                    Camera.CameraMovement.Zoom(MoveDirection.Out);
                    break;

            }
        }
    }
}
