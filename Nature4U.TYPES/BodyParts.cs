using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nature4U.TYPES
{
    public class BodyParts
    {
        #region Propiedades
        private int _BodyPartID;
        private string _Name;
        private string _Description;
        private int _BodyParentID;
        #endregion

        #region Atributos
        public int BodyPartID
        {
            get { return _BodyPartID; }
            set { _BodyPartID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public int BodyParentID
        {
            get { return _BodyParentID; }
            set { _BodyParentID = value; }
        }
        #endregion
    }
}
