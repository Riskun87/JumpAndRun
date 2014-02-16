using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;

namespace Model
{
    public delegate void SkeletonTrackerEvent();
    
    public class SkeletonTracker
    {
        KinectSensor sensor = null;
        Body body = null;

        public event SkeletonTrackerEvent SkeletonEvent;
        
        public void Start()
        {
            sensor = KinectSensor.KinectSensors[0];
            sensor.ColorStream.Enable();
            sensor.SkeletonStream.Enable();

            sensor.SkeletonFrameReady += runtime_SkeletonFrameReady;
            sensor.Start();
        }

        public void Stop()
        {
            sensor.Stop();
        }

        private void runtime_SkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            Skeleton[] skeletons = null;
            body = Body.Instance;

            using (SkeletonFrame skeletonFrame = e.OpenSkeletonFrame())
            {
                if (skeletonFrame != null)
                {
                    if (skeletons == null)
                    {
                        // Skelettarray zuweisen
                        skeletons = new Skeleton[skeletonFrame.SkeletonArrayLength];
                    }

                    skeletonFrame.CopySkeletonDataTo(skeletons);

                    if (skeletons.Length != 0)
                    {
                        // Getrackte Körperpunkte zwischenspeichern
                        Parallel.ForEach(skeletons, skel =>
                        {
                            setPosition(skel.Joints[JointType.AnkleLeft]);
                            setPosition(skel.Joints[JointType.AnkleRight]);
                            setPosition(skel.Joints[JointType.ElbowLeft]);
                            setPosition(skel.Joints[JointType.ElbowRight]);
                            setPosition(skel.Joints[JointType.FootLeft]);
                            setPosition(skel.Joints[JointType.FootRight]);
                            setPosition(skel.Joints[JointType.HandLeft]);
                            setPosition(skel.Joints[JointType.HandRight]);
                            setPosition(skel.Joints[JointType.Head]);
                            setPosition(skel.Joints[JointType.HipCenter]);
                            setPosition(skel.Joints[JointType.HipLeft]);
                            setPosition(skel.Joints[JointType.HipRight]);
                            setPosition(skel.Joints[JointType.KneeLeft]);
                            setPosition(skel.Joints[JointType.KneeRight]);
                            setPosition(skel.Joints[JointType.ShoulderCenter]);
                            setPosition(skel.Joints[JointType.ShoulderLeft]);
                            setPosition(skel.Joints[JointType.ShoulderRight]);
                            setPosition(skel.Joints[JointType.Spine]);
                            setPosition(skel.Joints[JointType.WristLeft]);
                            setPosition(skel.Joints[JointType.WristRight]);
                        });
                        if (SkeletonEvent != null)
                            SkeletonEvent();
                    }
                }
            }
        }

        

        private void setPosition(Joint joint)
        {
            if (joint.TrackingState == JointTrackingState.Tracked || joint.TrackingState == JointTrackingState.Inferred)
            {
                switch (joint.JointType)
                {
                    case JointType.AnkleLeft:
                        body.ankleLeft.x = joint.Position.X;
                        body.ankleLeft.y = joint.Position.Y;
                        body.ankleLeft.z = joint.Position.Z;
                        break;
                    case JointType.AnkleRight:
                        body.ankleRight.x = joint.Position.X;
                        body.ankleRight.y = joint.Position.Y;
                        body.ankleRight.z = joint.Position.Z;
                        break;
                    case JointType.ElbowLeft:
                        body.elbowLeft.x = joint.Position.X;
                        body.elbowLeft.y = joint.Position.Y;
                        body.elbowLeft.z = joint.Position.Z;
                        break;
                    case JointType.ElbowRight:
                        body.elbowRight.x = joint.Position.X;
                        body.elbowRight.y = joint.Position.Y;
                        body.elbowRight.z = joint.Position.Z;
                        break;
                    case JointType.FootLeft:
                        body.footLeft.x = joint.Position.X;
                        body.footLeft.y = joint.Position.Y;
                        body.footLeft.z = joint.Position.Z;
                        break;
                    case JointType.FootRight:
                        body.footRight.x = joint.Position.X;
                        body.footRight.y = joint.Position.Y;
                        body.footRight.z = joint.Position.Z;
                        break;
                    case JointType.HandRight:
                        body.handRight.x = joint.Position.X;
                        body.handRight.y = joint.Position.Y;
                        body.handRight.z = joint.Position.Z;
                        break;
                    case JointType.HandLeft:
                        body.handLeft.x = joint.Position.X;
                        body.handLeft.y = joint.Position.Y;
                        body.handLeft.z = joint.Position.Z;
                        break;
                    case JointType.Head:
                        body.head.x = joint.Position.X;
                        body.head.y = joint.Position.Y;
                        body.head.z = joint.Position.Z;
                        break;
                    case JointType.HipCenter:
                        body.hipCenter.x = joint.Position.X;
                        body.hipCenter.y = joint.Position.Y;
                        body.hipCenter.z = joint.Position.Z;
                        break;
                    case JointType.HipLeft:
                        body.hipLeft.x = joint.Position.X;
                        body.hipLeft.y = joint.Position.Y;
                        body.hipLeft.z = joint.Position.Z;
                        break;
                    case JointType.HipRight:
                        body.hipRight.x = joint.Position.X;
                        body.hipRight.y = joint.Position.Y;
                        body.hipRight.z = joint.Position.Z;
                        break;
                    case JointType.KneeLeft:
                        body.kneeLeft.x = joint.Position.X;
                        body.kneeLeft.y = joint.Position.Y;
                        body.kneeLeft.z = joint.Position.Z;
                        break;
                    case JointType.KneeRight:
                        body.kneeRight.x = joint.Position.X;
                        body.kneeRight.y = joint.Position.Y;
                        body.kneeRight.z = joint.Position.Z;
                        break;
                    case JointType.ShoulderCenter:
                        body.shoulderCenter.x = joint.Position.X;
                        body.shoulderCenter.y = joint.Position.Y;
                        body.shoulderCenter.z = joint.Position.Z;
                        break;
                    case JointType.ShoulderLeft:
                        body.shoulderLeft.x = joint.Position.X;
                        body.shoulderLeft.y = joint.Position.Y;
                        body.shoulderLeft.z = joint.Position.Z;
                        break;
                    case JointType.ShoulderRight:
                        body.shoulderRight.x = joint.Position.X;
                        body.shoulderRight.y = joint.Position.Y;
                        body.shoulderRight.z = joint.Position.Z;
                        break;
                    case JointType.Spine:
                        body.spine.x = joint.Position.X;
                        body.spine.y = joint.Position.Y;
                        body.spine.z = joint.Position.Z;
                        break;
                    case JointType.WristLeft:
                        body.wristLeft.x = joint.Position.X;
                        body.wristLeft.y = joint.Position.Y;
                        body.wristLeft.z = joint.Position.Z;
                        break;
                    case JointType.WristRight:
                        body.wristRight.x = joint.Position.X;
                        body.wristRight.y = joint.Position.Y;
                        body.wristRight.z = joint.Position.Z;
                        break;
                }
            }
        }
    }
}
