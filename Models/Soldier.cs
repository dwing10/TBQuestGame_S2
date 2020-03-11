using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame_S1.Models
{
    public class Soldier : Character
    {
        #region Fields

        private string _description;

        #endregion

        #region Properties
        
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        #endregion

        #region Constructors


        #endregion
    }
}
