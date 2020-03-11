using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame_S1.Models;
using System.Collections.ObjectModel;

namespace TBQuestGame_S1.PresentationLayer
{
    public class GameSessionViewModel : ObservableObject
    {
        #region Fields

        private Player _player;
        private List<string> _messages;

        private Map _gameMap;
        private Location _currentLocation;
        private string _currentLocationName;
        private ObservableCollection<Location> _accessobleLocations;

        #endregion

        #region Properties

        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        public string MessageDisplay
        {
            get { return string.Join("\n\n", _messages); }
        }

        public Map GameMap
        {
            get { return _gameMap; }
            set { _gameMap = value; }
        }

        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChange(nameof(CurrentLocation));
            }
        }

        public string CurrentLocationName
        {
            get { return _currentLocationName; }
            set
            {
                _currentLocationName = value;
                OnPropertyChange("CurrentLocation");
            }
        }

        public ObservableCollection<Location> AccessibleLocations
        {
            get { return _accessobleLocations; }
            set
            {
                _accessobleLocations = value;
                OnPropertyChange(nameof(AccessibleLocations));
            }
        }
        #endregion

        #region Constructors

        public GameSessionViewModel()
        {

        }

        public GameSessionViewModel(Player player, List<string> initialMessage, Map gameMap)
        {
            _player = player;
            _gameMap = gameMap;
            _currentLocation = _gameMap.CurrentLocation;
            _accessobleLocations = new ObservableCollection<Location>();
            _messages = initialMessage;
        }

        #endregion

        #region Methods

        /// <summary>
        /// update the accessible location
        /// </summary>
        private void UpdateAccessibleLocations()
        {
            _accessobleLocations.Clear();

            foreach (Location location in _gameMap.Locations)
            {
                if (location.IsAccessible == true)
                {
                    _accessobleLocations.Add(location);
                }
            }

            _accessobleLocations.Remove(_accessobleLocations.FirstOrDefault(l => l == _currentLocation));

            OnPropertyChange(nameof(AccessibleLocations));
        }

        /// <summary>
        /// Binds buttons to locations
        /// </summary>
        public void Move(string tagName)
        {
            switch (tagName)
            {
                case "Alheimurrinn":                    
                    foreach (Location location in AccessibleLocations)
                    {
                        if (tagName == location.Name)
                        {
                            CurrentLocation = location;
                        }
                    }
                    break;

                case "Qua Redi":
                    foreach (Location location in AccessibleLocations)
                    {
                        if (tagName == location.Name)
                        {
                            CurrentLocation = location;
                        }
                    }
                    break;

                case "Dore":
                    foreach (Location location in AccessibleLocations)
                    {
                        if (tagName == location.Name)
                        {
                            CurrentLocation = location;
                        }
                    }
                    break;

                case "North Bourg":
                    foreach (Location location in AccessibleLocations)
                    {
                        if (tagName == location.Name)
                        {
                            CurrentLocation = location;
                        }
                    }
                    break;

                case "South Bourg":
                    foreach (Location location in AccessibleLocations)
                    {
                        if (tagName == location.Name)
                        {
                            CurrentLocation = location;
                        }
                    }
                    break;

                default:
                    break;
            }

            UpdateAccessibleLocations();
        }

        /// <summary>
        /// Opens barracks window
        /// </summary>
        public void ShowBarracks()
        {
            BarracksView barracksView = new BarracksView(_player);
            barracksView.Show();
        }

        /// <summary>
        /// opens map window
        /// </summary>
        public void ShowMap()
        {
            MapView map = new MapView();
            map.Show();
        }

        /// <summary>
        /// opens information window
        /// </summary>
        public void ShowInfo()
        {
            InformationView info = new InformationView();
            info.Show();
        }

        #endregion
    }
}
