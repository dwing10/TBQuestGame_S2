using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame_S1.Models
{
    public class Player : Character
    {
        #region Enums
        public enum Gender
        {
            male,
            female
        }

        public enum StartStyle
        {
            neutral,
            offensive,
            deffensive
        }
        #endregion

        #region Fields
        private string _legionName;
        private Gender _playerGender;
        private StartStyle _playerStartStyle;
        private int _gold;
        #endregion

        #region Properties
        public string LegionName
        {
            get { return _legionName; }
            set { _legionName = value; }
        }

        public Gender PlayerGender
        {
            get { return _playerGender; }
            set { _playerGender = value; }
        }

        public StartStyle PlayerStartStyle
        {
            get { return _playerStartStyle; }
            set { _playerStartStyle = value; }
        }

        public int Gold
        {
            get { return _gold; }
            set { _gold = value; }
        }
        #endregion

        #region Constructors



        #endregion
    }
}
