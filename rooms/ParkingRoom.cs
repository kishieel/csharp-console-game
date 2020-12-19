using System;
using System.Collections.Generic;

namespace RGame {
    [Serializable]
    class ParkingRoom : Room {
        public override string RoomName { get => "Parking Steel Mountain"; }

        public override Dictionary<Point, Interactable> Interactables {
            get => new Dictionary<Point, Interactable>() {
                { new Point( 26, 6 ), new Door( "lobby", new Point( 26, 14) ) },
                { new Point( 27, 6 ), new Door( "lobby", new Point( 27, 14) ) },
            };
        }

        public override string[] MapLayer {
            get => new string[] {
                @"╔════════════════════════════════════════════════════════╗",
                @"║   ⁙██▁██▁██▁██████████████████████████▁██▁██▁██   ##$@#║",
                @"║ ⁙  █████████████▁████▁██████▁████▁█████████████  #@%##$║",
                @"║   ╬██▁██▁██▁██████████████████████████▁██▁██▁██  ##@@##║",
                @"║  ═╬█████████████▁████▁██████▁████▁█████████████   ##%#@║",
                @"║ ══╬══    ╬   ███████████  ███████████  #@#%        #╬@ ║",
                @"║  ═╬═  ⁙ ═╬═  ███▒████▒██▁▁██▒████▒███ ###%#@#    ⁙  ║  ║",
                @"║ ══╬══  ══╬══          ⁙⁙⁙⁙⁙⁙  ⁙       #@#@##@          ║",
                @"║ ● ║      ║   ●  ⁙     ⁙⁙⁙⁙⁙⁙       ●    #╬#    ⁙  ⁙ ●  ║",
                @"║ │    ⁙ _____ │    ⁙   ⁙⁙⁙⁙⁙⁙⊌  ⁙   │     ║ _____    │  ║",
                @"║-┴--≍--/▜███▛\┴-≍---------------≍---┴------/▜███▛\---┴--║",
                @"║      |\o ~ o/| ----     ----     |       |\o ~ o/|     ║",
                @"║      | █-=-█ |   ----     ----   |       | █-=-█ |     ║",
                @"║      |       |     ----     ---- |       |       |     ║",
                @"╚════════════════════════════════════════════════════════╝",
            };
        }

        public override string[] ColorsLayer {
            get => new string[] {
                @"╔════════════════════════════════════════════════════════╗",
                @"║   GC█B██B██B█R██████████RR██████████R█B██B██B█C   GGCGG║",
                @"║ G  C█████████R██B████B██████B████B██R█████████C  GCGGGC║",
                @"║   GC█B██B██B█R██████████RR██████████R█B██B██B█C  GGCCGG║",
                @"║  GGCCCCCCCCCCR██B████B██████B████B██RCCCCCCCCCC   CGGGC║",
                @"║ GGGGG    G   R██████████  ██████████R  GCGG        GYG ║",
                @"║  GGG  G GGG  RRRRRRRRRRRMMRRRRRRRRRRR GGGCCGG    G  Y  ║",
                @"║ GGGGG  GGGGG          ⁙⁙⁙⁙⁙⁙  G       GGCGGGC          ║",
                @"║ B Y      Y   B  G     ⁙⁙⁙⁙⁙⁙       B    GYG    G  G B  ║",
                @"║ Y    G RRRRR Y    G   ⁙⁙⁙⁙⁙⁙C  G   Y     Y BBBBB    Y  ║",
                @"║-Y--≍--RBBBBBRY-≍---------------≍---Y------BCCCCCB---Y--║",
                @"║      |RY W YR| YYYY     YYYY     |       |BY R YB|     ║",
                @"║      | BCCCB |   YYYY     YYYY   |       | BCCCB |     ║",
                @"║      |       |     YYYY     YYYY |       |       |     ║",
                @"╚════════════════════════════════════════════════════════╝",
            };
        }

        public override string[] CollisionsLayer {
            get => new string[] {
                @"##########################################################",
                @"#   ⁙############################################   @@@@@#",
                @"# ⁙  ############################################  @@@@@@#",
                @"#   @############################################  @@@@@@#",
                @"#  @@############################################   @@@@@#",
                @"# @@@@@    @   ########################  @@@@        @@@ #",
                @"#  @@@  ⁙ @@@  ###########▁▁########### @@@@@@@    ⁙  #  #",
                @"# @@@@@  @@@@@          ⁙⁙⁙⁙⁙⁙  ⁙        @@@@@@          #",
                @"# @ #      #   @  ⁙     ⁙⁙⁙⁙⁙⁙       @    @@@    ⁙  ⁙ @  #",
                @"# @    ⁙ _____ @    ⁙   ⁙⁙⁙⁙⁙⁙#  ⁙   @     # _____    @  #",
                @"#-┴--≍--@@@@@@@┴-≍---------------≍---┴------@@@@@@@---┴--#",
                @"#      |@@@@@@@| ----     ----     |       |@@@@@@@|     #",
                @"#      | ##### |   ----     ----   |       | ##### |     #",
                @"#      |       |     ----     ---- |       |       |     #",
                @"##########################################################",
            };
        }

    }
}