using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsWork
{
    class Constants
    {
        public const int EMPTY = 0;
        public const int EXIT_INDEX = 0;
        public const int EXIT_CODE = 0;
        public const int INSERT_INDEX = 1;
        public const string FIRST_INSERT_MESSAGE = "Remember, The First Insert Determine The Type Of All Next Inserts!";
        public const string INSERT_MESSAGE = "Enter A Value To Insert: ";
        public const string EXIT_MESSAGE = "Exiting...";
        public const string EMPTY_INPUT = "";
        public const string ARROW = " -> ";
        public const int DELETE_INDEX = 2;
        public const string DELETE_MESSAGE = "Enter A Value To Delete: ";
        public const string INVALID_INDEX = "Invalid Input!";
        public const string MENU_ERROR = "'{0}' Is Not In The Menu!";
        public const string DONE_MESSAGE = "\nDone!\n";
        public const string ERROR = "Error!";
        public const string CONTINUE_MESSAGE = "\nPress Any Key To Continue...";
        public const int PRE_ORDER_INDEX = 3;
        public const int IN_ORDER_INDEX = 4;
        public const int POST_ORDER_INDEX = 5;
        public const int NUMBER_INDEX = 1;
        public const int STRING_INDEX = 2;
        public const string INVLID_TYPE = "The Type Is Not Matched To The Chosen Type!";
        public const string NOT_FOUND_ERROR = "The Value Does Not Exist In The Tree!";
        public const string EMPTY_TREE = "The Tree Is Empty :)";
        public const string MENU = @"
==================================
Tree Type: {0}
==================================
== 1- Insert Value              ==
== 2- Delete Value              ==
== 3- PreOrder Print            ==
== 4- InOrder Print             ==
== 5- PostOrder Print           ==
== 0- Exit                      ==
==================================         
            ";
    }
}
