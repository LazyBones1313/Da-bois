using System.Collections.Generic;
using Unit06.Game.Casting;


namespace Unit06
{
    public class Constants
    {
        // ----------------------------------------------------------------------------------------- 
        // GENERAL GAME CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // GAME
        public static string GAME_NAME = "Martian";
        public static int FRAME_RATE = 60;

        // SCREEN
        public static int SCREEN_WIDTH = 1040;
        public static int SCREEN_HEIGHT = 680;
        public static int CENTER_X = SCREEN_WIDTH / 2;
        public static int CENTER_Y = SCREEN_HEIGHT / 2;
        public static int GROUND_Y = SCREEN_HEIGHT - 80;

        // FONT
        // public static string FONT_FILE = "Assets/Fonts/zorque.otf";
        // public static int FONT_SIZE = 32;

        // SOUND
        // public static string BOUNCE_SOUND = "Assets/Sounds/boing.wav";
        // public static string WELCOME_SOUND = "Assets/Sounds/start.wav";
        // public static string OVER_SOUND = "Assets/Sounds/over.wav";

        // TEXT
        public static int ALIGN_LEFT = 0;
        public static int ALIGN_CENTER = 1;
        public static int ALIGN_RIGHT = 2;


        // COLORS
        public static Color BLACK = new Color(0, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color PURPLE = new Color(255, 0, 255);

        // KEYS
        public static string LEFT = "left";
        public static string RIGHT = "right";
        public static string UP = "up";
        public static string DOWN = "down";
        public static string SPACE = "space";
        public static string ENTER = "enter";
        public static string PAUSE = "p";

        // SCENES
        public static string NEW_GAME = "new_game";
        public static string TRY_AGAIN = "try_again";
        public static string NEXT_LEVEL = "next_level";
        public static string IN_PLAY = "in_play";
        public static string GAME_OVER = "game_over";

        // ----------------------------------------------------------------------------------------- 
        // SCRIPTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // PHASES
        public static string INITIALIZE = "initialize";
        public static string LOAD = "load";
        public static string INPUT = "input";
        public static string UPDATE = "update";
        public static string OUTPUT = "output";
        public static string UNLOAD = "unload";
        public static string RELEASE = "release";

        // ----------------------------------------------------------------------------------------- 
        // CASTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 


        // Player
        public static string PLAYER_GROUP = "player";
        public static string PLAYER_IMAGE = "Assets/Images/purple.png";
        public static int PLAYER_WIDTH = 50;
        public static int PLAYER_HEIGHT = 100;
        public static int PLAYER_MOVE_VELOCITY = 20;


        // DIALOG
        public static string DIALOG_GROUP = "dialogs";
        public static string ENTER_TO_START = "PRESS ENTER TO START";
        public static string PREP_TO_LAUNCH = "PREPARING TO LAUNCH";
        public static string WAS_GOOD_GAME = "GAME OVER";

    }
}