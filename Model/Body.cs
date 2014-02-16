using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Body : EventArgs
    {
        /// <summary>Instanz des Positionobjektes</summary>
        private static Body instance;
        
        /// <summary>Koordinatenobjekt des Punktes: Fussgelenk links</summary>
        public Position ankleLeft { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Fussgelenk rechts</summary>
        public Position ankleRight { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Ellenbogen links</summary>
        public Position elbowLeft { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Ellenbogen rechts</summary>
        public Position elbowRight { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Fuss links</summary>
        public Position footLeft { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Fuss rechts</summary>
        public Position footRight { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Hand links</summary>
        public Position handLeft { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Hand rechts</summary>
        public Position handRight { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Kopf</summary>
        public Position head { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Hüfte mitte</summary>
        public Position hipCenter { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Hüfte links</summary>
        public Position hipLeft { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Hüfte rechts</summary>
        public Position hipRight { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Knie links</summary>
        public Position kneeLeft { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Knie rechts</summary>
        public Position kneeRight { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Schulter mitte</summary>
        public Position shoulderCenter { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Schulter links</summary>
        public Position shoulderLeft { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Schulter rechts</summary>
        public Position shoulderRight { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Rückgrat</summary>
        public Position spine { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Handgelenk links</summary>
        public Position wristLeft { get; set; }
        /// <summary>Koordinatenobjekt des Punktes: Handgelenk rechts</summary>
        public Position wristRight { get; set; }

        /// <summary>
        /// Konstruktor, Initialisiert die Körperpunkte
        /// </summary>
        private Body()
        {
            ankleLeft = new Position();
            ankleRight = new Position();
            elbowLeft = new Position();
            elbowRight = new Position();
            footLeft = new Position();
            footRight = new Position();
            handLeft = new Position();
            handRight = new Position();
            head = new Position();
            hipCenter = new Position();
            hipLeft = new Position();
            hipRight = new Position();
            kneeLeft = new Position();
            kneeRight = new Position();
            shoulderCenter = new Position();
            shoulderLeft = new Position();
            shoulderRight = new Position();
            spine = new Position();
            wristLeft = new Position();
            wristRight = new Position();
        }

        /// <summary>
        /// stellt sicher, dass diese Klasse nur einmal Instanziert wird.
        /// </summary>
        /// <returns>instance der Klasse Position</returns>
        public static Body Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Body();
                }
                return instance;
            }
        }

        
    }
}
