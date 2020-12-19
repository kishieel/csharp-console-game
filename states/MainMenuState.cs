using System;
using System.Collections.Generic;

namespace RGame {
    class MainMenuState : GameState {
        private const string NEW_GAME = "NOWA GRA";
        private const string LOAD_GAME = "WCZYTAJ GRE";
        private const string END_GAME = "KONIEC GRY";

        private Menu menu = new Menu(
            new List<string>() { NEW_GAME, LOAD_GAME, END_GAME }
        );

        public override void Draw() {
            Headers.Menu();
            menu.Draw();
        }

        public override void DrawHints() {
            Hints.Menu();
            Console.WriteLine();
        }

        public override bool HandleKeyPress( char choice ) {
            if ( menu.HandleKeyPress( choice) ) {
                return true;
            } else if ( choice == (char) 32 ) {
                if ( menu.GetCurrent() == NEW_GAME ) {
//                    GameController.Instance().SetRoom( RoomsRepository.Instance().Get( "eliot_house" ) );
//                    GameController.Instance().SetPlayer( new Point( 3, 6 ) );
//                    GameController.Instance().SetDialog( new WakeUpDialog( 0 ) );

                    GameController.Instance().SetRoom( RoomsRepository.Instance().Get( "coney_island" ) );
                    GameController.Instance().SetPlayer( new Point( 20, 12 ) );

                    this.context.SetState( new PlayState() );
                } else if ( menu.GetCurrent() == LOAD_GAME ) {
                    this.context.SetState( new LoadState( this ) );
                } else if ( menu.GetCurrent() == END_GAME ) {
                    Console.Clear();
                    Environment.Exit(0);
                }

                return true;
            }

            return false;
        }


//        private int cursorPos = 0;
//        private string[] options = { "NOWA GRA", "WCZYTAJ GRE", "KONIEC GRY" };
//
//        public override void Draw() {
//            Headers.Menu();
//
//            for ( int i = 0; i < options.Length; i++ ) {
//                if ( cursorPos == i ) {
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.Write("> ");
//                    Console.ForegroundColor = ConsoleColor.White;
//                } else {
//                    Console.Write("  ");
//                }
//
//                Console.WriteLine( options[i] );
//            }
//            Console.WriteLine();
//        }
//
//        public override void Hints() {
//            Utils.PrintHint( "[SPACE]", "Wybierz" );
//            Utils.PrintHint( "[W]", "Góra" );
//            Utils.PrintHint( "[S]", "Dół" );
//            Console.WriteLine();
//        }
//
//        public override void HandleKeyPress( char choice ) {
//            if ( choice == 'w' ) {
//                cursorPos = ( cursorPos - 1 ) % options.Length;
//                if ( cursorPos < 0 ) {
//                    cursorPos = options.Length - 1;
//                }
//            } else if ( choice == 's' ) {
//                cursorPos = ( cursorPos + 1 ) % options.Length;
//            } else if ( choice == (char) 32 ) {
//                if ( options[ cursorPos ] == "NOWA GRA" ) {
//                    Console.WriteLine( "Jeszcze nie czas" );
//                } else if ( options[ cursorPos ] == "WCZYTAJ GRE" ) {
//                    // WCZYTAJ
//                } else if ( options[ cursorPos ] == "KONIEC GRY" ) {
//                    Console.Clear();
//                    Console.WriteLine( Utils.Yellow + "DZIĘKUJE ZA GRE - DO ZOBACZENIA :3\n" + Utils.White );
//                    Environment.Exit(0);
//                }
//            }
//        }

    }
}
