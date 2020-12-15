using System;

namespace Game {
    class PlayState : IGameState {

        public override void Draw() {
            Headers.Branding();
            GameController.GetInstance().GetRoom().Draw(); // Demeter chyba cierpi katusze jak to widzi XD
            Console.WriteLine();
        }

        public override void Hints()
        {
            Utils.PrintHint( "[WSAD]", "Poruszanie" );
            Utils.PrintHint( "[SPACE]", "Interakcja" );
            Utils.PrintHint( "[Q]", "Zadania" );
            Utils.PrintHint( "[E]", "Ekwipunek" );
            Utils.PrintHint( "[ESC]", "Menu" );
            Console.WriteLine();
        }

        public override void HandleKeyPress( char choice ) {
            Player player = GameController.GetInstance().GetPlayer();
            IRoom room = GameController.GetInstance().GetRoom();

            if ( choice == 'e' ) {
                this.context.SetState( new EquipmentState() );
            } else if ( choice == 'q' ) {
                this.context.SetState( new QuestsState() );
            } else if ( choice == ( char ) 32 ) {
                room.Interact( player );
            } else if ( choice == ( char ) 27 ) {
                this.context.SetState( new PauseMenuState() );
            } else if ( choice == 'w' ) {
                Player nextPlayer = new Player( player.X, player.Y - 1 );
                if ( nextPlayer.Y > 0 && nextPlayer.Y < room.GetHeight() ) {
                    if ( room.CollisionCheck( nextPlayer ) == false ) {
                        GameController.GetInstance().SetPlayer( nextPlayer );
                    }
                }
            }  else if ( choice == 's' ) {
                Player nextPlayer = new Player( player.X, player.Y + 1 );
                if ( nextPlayer.Y > 0 && nextPlayer.Y < room.GetHeight() ) {
                    if ( room.CollisionCheck( nextPlayer ) == false ) {
                        GameController.GetInstance().SetPlayer( nextPlayer );
                    }
                }
            } else if ( choice == 'a' ) {
                Player nextPlayer = new Player( player.X - 1, player.Y );
                if ( nextPlayer.X > 0 && nextPlayer.X < room.GetWidth() ) {
                    if ( room.CollisionCheck( nextPlayer ) == false ) {
                        GameController.GetInstance().SetPlayer( nextPlayer );
                    }
                }
            } else if ( choice == 'd' ) {
                Player nextPlayer = new Player( player.X + 1, player.Y );
                if ( nextPlayer.X > 0 && nextPlayer.X < room.GetWidth() ) {
                    if ( room.CollisionCheck( nextPlayer ) == false ) {
                        GameController.GetInstance().SetPlayer( nextPlayer );
                    }
                }
            }
        }

    }
}
