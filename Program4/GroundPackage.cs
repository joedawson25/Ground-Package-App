//Joe Dawson
//CIS 199-01
//Due Date: April 24, 2016
//Program 4
/*This program takes user input for a package and stores it in a list. 
The user can then select the package from the list and see its details or change the package's origin and destination zip code by clicking the appropriate buttons
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class GroundPackage
    {
        int _originZip; //backing variable for origin zip code
        int _destinationZip;//backing variable for destination zip code
        double _length;//backing variable for length of package
        double _width;//backing variable for width of package
        double _height;//backing variable for height of package
        double _weight;//backing variable for weight of package

        //Precondition: originzip 5 digits, > 0 destinationzip 5 digits, < 99999, length, width ,height, weight >0
        //Postcondition: allows operations to be preformed based on user entered data that is passed through the constructor
        public GroundPackage(int originzip, int destinationzip, double length, double width, double height, double weight)
        {
            OriginZip = originzip; //variable holding origin zip code passed through constructor
            DestinationZip = destinationzip;// variable holding destination zip code passed through constructor
            Length = length;// variable holding length passed through constructor
            Width = width;// variable holding width passed through constructor
            Height = height;// variable holding height passed through constructor
            Weight = weight;//// variable holding weight passed through constructor
        }

        //Precondition: none
        //Postcondition: _originZip value either returned or set
        public int OriginZip
        {
            get 
            {
                return _originZip;
            }
            set
            {
                if (value > 0 && value <= 99999)
                {
                    _originZip = value;
                }
                else
                {
                    _originZip = 0;
                }
            }
        }
        //Precondition: none
        //Postcondition: _destinationZip value either returned or set
        public int DestinationZip
        {
            get
            {
                return _destinationZip;
            }
            set
            {
                if (value > 0 && value <= 99999)
                {
                    _destinationZip = value;
                }
                else
                {
                    _destinationZip = 0;
                }
            }
        }
        //Precondition: none
        //Postcondition: _length value either returned or set
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    _length = 0;
                }
            }
        }
        //Precondition: none
        //Postcondition: _width value either returned or set
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    _width = 0;
                }
            }
        }
        //Precondition: none
        //Postcondition: _height value either returned or set
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    _height = 0;
                }

            }
        }
        //Precondition: none
        //Postcondition: _weight value either returned or set
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
                else
                {
                    _weight = 0;
                }
            }
        }
        //Precondition: none
        //Postcondition: returns difference between origin and destination zip codes
        public int ZoneDistance
        {
            get
            {
               return  Math.Abs((OriginZip/10000) - (DestinationZip/10000));
            }
        }
        //Precondition: none
        //Postcondition: Calculates cost to ship package and returns cost
        public double CalcCost()
        {
            double cost = .20 * (Length + Width + Height) + .5 * (ZoneDistance + 1) * (Weight);
            return cost;
        }
        //Precondition: none
        //Postcondition: converts values for above properties to strings and concactenates them 
        public override string ToString()
        {
            string oz = "Origin Zip: " + OriginZip.ToString("D5");
            string dz = "Destination Zip: " + DestinationZip.ToString("D5");
            string l = "Length: " + Length.ToString() + " " + "inches";
            string w = "Width: " + Width.ToString() + " " + "inches";
            string h = "Height: " + Height.ToString() + " " + "inches";
            string zd = "Zone Distance: " + ZoneDistance.ToString();
            string lbs = "Weight: " + Weight.ToString() + " " + "pounds";

            return oz + System.Environment.NewLine + dz + System.Environment.NewLine + zd + System.Environment.NewLine + l + System.Environment.NewLine + w + System.Environment.NewLine + h + System.Environment.NewLine + lbs;
        }
    
    }


}
