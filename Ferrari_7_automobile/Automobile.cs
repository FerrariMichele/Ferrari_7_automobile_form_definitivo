using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari_7_automobile
{
    public class Automobile
    {
        protected bool _motoreAcceso;
        protected int _velocita;
        protected int _marcia;
        protected int _giriMotore;

        public Automobile()
        {
            _motoreAcceso = false;
            _velocita = 0;
            _marcia = 0;
            _giriMotore = 0;
        }

        public bool MotoreAcceso
        {
            get { return _motoreAcceso; }
            set {  _motoreAcceso = value; }
        }

        public int Velocita
        {
            get { return _velocita; }
            set { _velocita = value; }
        }

        public int Marcia
        {
            get { return _marcia; }
            set { _marcia = value; }
        }

        public int GiriMotore
        {
            get { return _giriMotore; }
        }

        public void AccendiSpegniMotore()
        {
            if (_velocita == 0) 
            {
                MotoreAcceso = !MotoreAcceso;
                if (!MotoreAcceso)
                {
                    _velocita = 0;
                    _giriMotore = 0;
                    _marcia = 0;
                }
            }
        }

        private void CalcolaVelocita()
        {
            _velocita = GiriMotore * Marcia / 200;
        }


        public void Accelerare()
        {
            if (_motoreAcceso && _marcia > 0)
            {
                if (_giriMotore < 8000)
                {
                    _giriMotore += 2000;
                    CalcolaVelocita();
                }
            }
        }

        public void AumentaMarcia()
        {
            if (_motoreAcceso && _marcia < 5)
            {
                if (_marcia == 0)
                {
                    Marcia++;
                }
                if (_giriMotore >= 6000)
                {
                    CambiaMarcia();
                }
            }
        }

        private void CambiaMarcia()
        {
            _marcia++;
            _giriMotore = 2000;
            CalcolaVelocita();
        }

        public void Decelerare()
        {
            if (_motoreAcceso && _giriMotore > 0)
            {
                _giriMotore -= 2000;
                CalcolaVelocita();
            }
        }

        public void DiminuisciMarcia()
        {
            if (_motoreAcceso && _marcia > 0 )
            {
                if (_marcia == 1)
                    if (_velocita > 0)
                        return;
                    else
                    {
                        _marcia--;
                        _giriMotore = 0;
                    }
                else
                {
                    _marcia--;
                    _giriMotore = 4000;
                }
                CalcolaVelocita();
            }
        }
    }
}
