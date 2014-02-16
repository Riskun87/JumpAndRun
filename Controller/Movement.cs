using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using Model;

namespace Controller
{
    class Movement
    {
        /// <summary>Punkt ID Fuss links</summary>
        private int pointFootLeft = 0;
        /// <summary>Punkt ID Fuss rechts</summary>
        private int pointFootRight = 0;
        /// <summary>Punkt ID Hand links</summary>
        private int pointHandLeft = 0;
        /// <summary>Punkt ID Hand rechts</summary>
        private int pointHandRight = 0;
        /// <summary>Punkt ID Kopf</summary>
        private int pointHead = 0;

        /// <summary>Linien ID Unterarm links</summary>
        private int lineForearmLeft = 0;
        /// <summary>Linien ID Unterarm ¨rechts</summary>
        private int lineForearmRight = 0;
        /// <summary>Linien ID Oberarm links</summary>
        private int lineUpperarmLeft = 0;
        /// <summary>Linien ID Oberarm rechts</summary>
        private int lineUpperarmRight = 0;
        /// <summary>Linien ID Oberschenkel links</summary>
        private int lineThighLeft = 0;
        /// <summary>Linien ID Oberschenkel rechts</summary>
        private int lineThighRight = 0;
        /// <summary>Linien ID Unterschenkel links</summary>
        private int lineLowerlegLeft = 0;
        /// <summary>Linien ID Unterschenkel rechts</summary>
        private int lineLowerlegRight = 0;
        /// <summary>Linien ID Hüfte links</summary>
        private int lineHipLeft = 0;
        /// <summary>Linien ID Hüfte rechts</summary>
        private int lineHipRight = 0;
        /// <summary>Linien ID Hüfte</summary>
        private int lineHipCenter = 0;
        /// <summary>Linien ID Brust links</summary>
        private int lineBreastLeft = 0;
        /// <summary>Linien ID Brust rechts</summary>
        private int lineBreastRight = 0;
        /// <summary>Linien ID Brust</summary>
        private int lineBreastCenter = 0;

        /// <summary>Objekt mit den Koordinaten der getrackten Körperpunkte</summary>
        public Body body { get; set; }
        /// <summary>Objekt des Sensors</summary>
        private SkeletonTracker sensor = null;

        private int init = 0;

        /// <summary>
        /// Startet Kinect und registriert die Punkte und Linien des Körper in der Ausgabe
        /// </summary>
        public Movement()
        {
            // Sensor starten
            start();
        }

        /// <summary>
        /// Sensor starten
        /// </summary>
        public void start()
        {
            sensor = new SkeletonTracker();
            sensor.Start();
            sensor.SkeletonEvent += new SkeletonTrackerEvent(getEvent);
            body = Body.Instance;
        }

        /// <summary>
        /// Punkte und Linien für einen Körpder erstellen
        /// </summary>
        private void initialize()
        {
            pointFootLeft = Visualization.addPoint();
            pointFootRight = Visualization.addPoint();
            pointHandLeft = Visualization.addPoint();
            pointHandRight = Visualization.addPoint();
            pointHead = Visualization.addPoint();

            lineForearmLeft = Visualization.addLine();
            lineForearmRight = Visualization.addLine();
            lineUpperarmLeft = Visualization.addLine();
            lineUpperarmRight = Visualization.addLine();
            lineThighLeft = Visualization.addLine();
            lineThighRight = Visualization.addLine();
            lineLowerlegLeft = Visualization.addLine();
            lineLowerlegRight = Visualization.addLine();
            lineHipLeft = Visualization.addLine();
            lineHipRight = Visualization.addLine();
            lineHipCenter = Visualization.addLine();
            lineBreastLeft = Visualization.addLine();
            lineBreastRight = Visualization.addLine();
            lineBreastCenter = Visualization.addLine();
        }

        /// <summary>
        /// Punkte und Linien neu setzen und ausgabe neu Zeichnen
        /// </summary>
        public void update()
        {
            Visualization.updatePoint(pointFootLeft, body.footLeft.x, body.footLeft.y, body.footLeft.z * -1 + 7);
            Visualization.updatePoint(pointFootRight, body.footRight.x, body.footRight.y, body.footRight.z * -1 + 7);
            Visualization.updatePoint(pointHandLeft, body.handLeft.x, body.handLeft.y, body.handLeft.z * -1 + 7);
            Visualization.updatePoint(pointHandRight, body.handRight.x, body.handRight.y, body.handRight.z * -1 + 7);
            Visualization.updatePoint(pointHead, body.head.x, body.head.y, body.head.z * -1 + 7);

            Visualization.updateLine(lineForearmLeft, body.wristLeft.x, body.wristLeft.y, body.wristLeft.z * -1 + 7, body.elbowLeft.x, body.elbowLeft.y, body.elbowLeft.z * -1 + 7);
            Visualization.updateLine(lineForearmRight, body.wristRight.x, body.wristRight.y, body.wristRight.z * -1 + 7, body.elbowRight.x, body.elbowRight.y, body.elbowRight.z * -1 + 7);
            Visualization.updateLine(lineUpperarmLeft, body.elbowLeft.x, body.elbowLeft.y, body.elbowLeft.z * -1 + 7, body.shoulderLeft.x, body.shoulderLeft.y, body.shoulderLeft.z * -1 + 7);
            Visualization.updateLine(lineUpperarmRight, body.elbowRight.x, body.elbowRight.y, body.elbowRight.z * -1 + 7, body.shoulderRight.x, body.shoulderRight.y, body.shoulderRight.z * -1 + 7);
            Visualization.updateLine(lineLowerlegLeft, body.ankleLeft.x, body.ankleLeft.y, body.ankleLeft.z * -1 + 7, body.kneeLeft.x, body.kneeLeft.y, body.kneeLeft.z * -1 + 7);
            Visualization.updateLine(lineLowerlegRight, body.ankleRight.x, body.ankleRight.y, body.ankleRight.z * -1 + 7, body.kneeRight.x, body.kneeRight.y, body.kneeRight.z * -1 + 7);
            Visualization.updateLine(lineThighLeft, body.kneeLeft.x, body.kneeLeft.y, body.kneeLeft.z * -1 + 7, body.hipLeft.x, body.hipLeft.y, body.hipLeft.z * -1 + 7);
            Visualization.updateLine(lineThighRight, body.kneeRight.x, body.kneeRight.y, body.kneeRight.z * -1 + 7, body.hipRight.x, body.hipRight.y, body.hipRight.z * -1 + 7);
            Visualization.updateLine(lineHipLeft, body.hipLeft.x, body.hipLeft.y, body.hipLeft.z * -1 + 7, body.spine.x, body.spine.y, body.spine.z * -1 + 7);
            Visualization.updateLine(lineHipRight, body.hipRight.x, body.hipRight.y, body.hipRight.z * -1 + 7, body.spine.x, body.spine.y, body.spine.z * -1 + 7);
            Visualization.updateLine(lineHipCenter, body.hipLeft.x, body.hipLeft.y, body.hipLeft.z * -1 + 7, body.hipRight.x, body.hipRight.y, body.hipRight.z * -1 + 7);
            Visualization.updateLine(lineBreastLeft, body.shoulderLeft.x, body.shoulderLeft.y, body.shoulderLeft.z * -1 + 7, body.spine.x, body.spine.y, body.spine.z * -1 + 7);
            Visualization.updateLine(lineBreastRight, body.shoulderRight.x, body.shoulderRight.y, body.shoulderRight.z * -1 + 7, body.spine.x, body.spine.y, body.spine.z * -1 + 7);
            Visualization.updateLine(lineBreastCenter, body.shoulderLeft.x, body.shoulderLeft.y, body.shoulderLeft.z * -1 + 7, body.shoulderRight.x, body.shoulderRight.y, body.shoulderRight.z * -1 + 7);

            Visualization.draw();
        }

        /// <summary>
        /// Ausgabe und Sensor sauber Beenden
        /// </summary>
        public void end()
        {
            Visualization.close();
            sensor.Stop();
        }

        public void getEvent()
        {
            if (init == 0)
            {
                initialize();
                init = 1;
            }
            update();
            if (body.handRight.x >= 0.5 & body.handRight.y >= 0.5 & body.handLeft.x >= 0.5 & body.handLeft.y >= 0.5)
            {
                end();
            }
        }
    }
}
