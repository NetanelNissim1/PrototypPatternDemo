using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypPatternDemo
{
    public abstract class Shape : ICloneable
    {

        private string id;
        protected string type;
        public abstract void draw();

        public string getType()
        {
            return type;
        }

        public string getId()
        {
            return id;
        }

        public void setType(string type)
        {
            this.type = type;
        }
        public void setId(string id)
        {
            this.id = id;
        }


        public object Clone()
        {
            object clone = null;

            try
            {
                clone = base.MemberwiseClone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return clone;
        }
    }
}
