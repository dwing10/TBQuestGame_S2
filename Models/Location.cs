using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame_S1.Models
{
    public class Location
    {
        #region Fields
        private int _id;
        private string _name;
        private string _description;
        private string _message;
        private int _enemyRank;
        private int _enemyAttack;
        private int _enemyDefense;
        private bool _isAccessible;
        #endregion

        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public int EnemyRank
        {
            get { return _enemyRank; }
            set { _enemyRank = value; }
        }

        public int EnemyAttack
        {
            get { return _enemyAttack; }
            set { _enemyAttack = value; }
        }

        public int EnemyDefense
        {
            get { return _enemyDefense; }
            set { _enemyDefense = value; }
        }

        public bool IsAccessible
        {
            get { return _isAccessible; }
            set { _isAccessible = value; }
        }
        #endregion

        #region Constructors

        public Location()
        {

        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return _name;
        }

        #endregion
    }
}
