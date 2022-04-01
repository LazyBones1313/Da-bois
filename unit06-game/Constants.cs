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
        public static string FONT_FILE = "Assets/Fonts/PressStart2P-Regular.ttf";
        public static int FONT_SIZE = 20;

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

        //Gravity
        public static int GRAVITY_ACCELERATION = 2;

        // Stats
        public static string STATS_GROUP = "stats";
        public static int STATS_NUM_LIVES = 6;
        public static int STATS_NUM_SCRAP = 0;

        // HUD
        public static int HUD_MARGIN = 20;
        public static string LIVES_DISPLAY_GROUP = "lives_display";
        public static string SCRAP_DISPLAY_GROUP = "scrap_display";
        public static string SCRAP_DISPLAY_FORMAT = "SCRAP COUNT - {0}";
        public static string TIME_DISPLAY_GROUP = "time_display";
        public static Dictionary<int, string> LIVES_IMAGES = new Dictionary<int, string> () {
            {0, "Assets/Images/Health/0.png"},
            {1, "Assets/Images/Health/1.png"},
            {2, "Assets/Images/Health/2.png"},
            {3, "Assets/Images/Health/3.png"},
            {4, "Assets/Images/Health/4.png"},
            {5, "Assets/Images/Health/5.png"},
            {6, "Assets/Images/Health/6.png"}
        };
        
        // Player
        public static string PLAYER_GROUP = "player";
        public static string PLAYER_IMAGE = "Assets/Images/purple.png";
        public static int PLAYER_WIDTH = 50;
        public static int PLAYER_HEIGHT = 100;
        public static int PLAYER_MOVE_VELOCITY = 15;
        public static int PLAYER_JUMP_VELOCITY = 25;
        public static int PLAYER_DIST_FROM_CENTER_X = 150;
        public static int PLAYER_MIN_RANGE_X = CENTER_X - PLAYER_DIST_FROM_CENTER_X;
        public static int PLAYER_MAX_RANGE_X = CENTER_X + PLAYER_DIST_FROM_CENTER_X;


        // Rocket
        public static string ROCKET_GROUP = "rocket";
        public static string ROCKET_IMAGE = "Assets/Images/rocket.png";
        public static int ROCKET_WIDTH = 240;
        public static int ROCKET_HEIGHT = 410;
        public static int ROCKET_DIST_FROM_GROUND = 40;

        // Debree
        public static string DEBREE_GROUP = "debree";
        public static string DEBREE_IMAGE = "Assets/Images/yellow.png";
        public static int DEBREE_VALUE = -10;
        public static int DEBREE_WIDTH = 50;
        public static int DEBREE_HEIGHT = 50;

        // Food
        public static string FOOD_GROUP = "food";
        public static string FOOD_IMAGE = "Assets/Images/red.png";
        public static int FOOD_VALUE = 10;
        public static int FOOD_WIDTH = 50;
        public static int FOOD_HEIGHT = 50;

        // Water
        public static string WATER_GROUP = "water";
        public static string WATER_IMAGE = "Assets/Images/blue.png";
        public static int WATER_VALUE = 5;
        public static int WATER_WIDTH = 50;
        public static int WATER_HEIGHT = 50;

        // Scrap
        public static string SCRAP_GROUP = "scrap";
        public static string SCRAP_IMAGE = "Assets/Images/gray.png";
        public static int SCRAP_VALUE = 1;
        public static int SCRAP_WIDTH = 50;
        public static int SCRAP_HEIGHT = 50;


        // Room
        public static string ROOM_GROUP = "room";
        public static string ROOM_IMAGE = "Assets/Images/background.png";
        public static int ROOM_HEIGHT = SCREEN_HEIGHT;
        public static int ROOM_WIDTH = 3317;
        public static int ROOM_CENTER_X = ROOM_WIDTH / 2;

        // SCREEN
        public static string SCREEN_GROUP = "screen";



        // DIALOG
        public static string DIALOG_GROUP = "dialogs";
        public static string ENTER_TO_START = "PRESS ENTER TO START";
        public static string PREP_TO_LAUNCH = "PREPARING TO LAUNCH";
        public static string WAS_GOOD_GAME = "GAME OVER";

    }
}