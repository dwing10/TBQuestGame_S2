using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame_S1.Models;

namespace TBQuestGame_S1.DataLayer
{
    class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                ID = 1,
                Name = "Spartacus",
                PlayerGender = Player.Gender.male,
                Title = Character.CharacterTitle.Praetor,
                PlayerStartStyle = Player.StartStyle.neutral,
                Gold = 1000,
                Attack = 500,
                Defense = 500,
                Rank = 1
            };
        }

        public static Map GameMap()
        {
            Map gameMap = new Map();
            Random rand = new Random();

            gameMap.Locations.Add(new Location()
            {
                ID = 1,
                Name = "Aquila Empire",
                Description = "\t The might of the Aquila Empire is unmatched by any in the world of Mundas. " +
                "The legions of the Aquila Empire are led by high ranking generals known as Imperators who have " +
                "been tasked with crushing any who oppose the mighty empire.",
                EnemyRank = 0,
                EnemyAttack = 0,
                EnemyDefense = 0,
                IsAccessible = true
            });

            gameMap.Locations.Add(new Location()
            {
                ID = 2,
                Name = "Alheimurrinn",
                Description = "\t Alheimurinn is a powerful kingdom located west of the Aquila Empire. " +
                "They are the greatest threat to the Empire and must be destroyed, but take heed as it will " +
                "take a mighty legion to topple this kingdom.",
                EnemyRank = 5,
                EnemyAttack = rand.Next(1250, 1500),
                EnemyDefense = rand.Next(1250, 1500),
                IsAccessible = true
            });

            gameMap.Locations.Add(new Location()
            {
                ID = 3,
                Name = "Dore",
                Description = "\t The kingdom of Dore is a wealthy country at the edge of the southern desert. " +
                "They have a rather impressive army despite the kingdom's small size. Conquer Dore and discover the " +
                "treasures it holds.",
                EnemyRank = 3,
                EnemyAttack = rand.Next(750, 999),
                EnemyDefense = rand.Next(750, 999),
                IsAccessible = true
            });

            gameMap.Locations.Add(new Location()
            {
                ID = 4,
                Name = "Qua Redi",
                Description = "\t The Empire of Qua Redi is the kingdom of Dore's western neighbor. This vast " +
                "empire dominates the southern desert with a massive army. Crippling this Empire will require " +
                "careful planning. ",
                EnemyRank = 4,
                EnemyAttack = rand.Next(1000, 1249),
                EnemyDefense = rand.Next(1000, 1249),
                IsAccessible = true
            });

            gameMap.Locations.Add(new Location()
            {
                ID = 5,
                Name = "North Bourg",
                Description = "\t North Bourg is the Aquila Empire's eastern neighbor. North Bourg is comprised " +
                "primarily of small towns and settlements. The kingdom is constantly at war with South Bourg, and as such " +
                "they have been severely weakened.",
                EnemyRank = 1,
                EnemyAttack = rand.Next(500, 999),
                EnemyDefense = rand.Next(500, 999),
                IsAccessible = true
            });

            gameMap.Locations.Add(new Location()
            {
                ID = 6,
                Name = "South Bourg",
                Description = "\t South and North Bourg were once a single kingdom called Bourg. However, it has been " +
                "split into two kingdoms. South Bourg stands as weak and vulnerable as North Bourg, making it the perfect " +
                "target for an inexperienced Imperator.",
                EnemyRank = 2,
                EnemyAttack = rand.Next(1000, 1499),
                EnemyDefense = rand.Next(1000, 1499),
                IsAccessible = true
            });

            gameMap.CurrentLocation = gameMap.Locations.FirstOrDefault(l => l.ID == 1);

            return gameMap;
        }

        public static List<string> InitialMessage()
        {
            return new List<string>()
            {
                "Welcome to Mundas, a land that is ravaged by waring factions and barbarian hordes. " +
                "You are an Imperator, a high ranking general, of the Aquila Empire. " +
                "You have been tasked by your Emperor and the High Council to lay seige on enemy lands. " +
                "Along with the title of Imperator, you have been given a legion and a starting sum of gold. " +
                "Use your newfound status and wealth wisely. The Emperor will not tolerate failure. "
            };
        }
    }
}
