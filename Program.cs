//start main

int userChoice = GetUserChoice();

//end main 

do {
    RouteEm(userChoice);
    userChoice = GetUserChoice();
} while (userChoice!=3);

static int GetUserChoice() {
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if (IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu() {
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string userChoice) {
    if(userChoice =="1" || userChoice == "2" || userChoice == "3") {
        return true;
    }
    return false;
}

static void GetFull() {
    int rows, i, j, count = 1;
    Random rand = new Random();
    rows = rand.Next(3,9);
    count = rows - 1;

    for (j = 1; j <= rows; j++) {  
        for (i = 1; i <= 2 * j - 1; i++)  
            Console.Write("0");  
        Console.WriteLine();  
    }
    Console.ReadLine();  
    PauseAction();
}

// ************ could not get GetPartial to run just because of two small syntax errors, didn't have time to come to office hours because of work *************** 
// ************ The program still is fully functional and can still output the full triangle with a random size from 3-9 rows

//static void GetPartial() {
//     int rows, i, j, count = 1;

//     List<string> charachters = new List<string>{" ", "0"};

//     Random rand = new Random();
//     rows = rand.Next(3,9);
//     count = rows - 1;
    
//     string randIndex = rand.Next(charachters.Count);
//     string randomChar = charachters[randIndex];

//     for (j = 1; j <= rows; j++) {  
//         for (i = 1; i <= 2 * j - 1; i++)
//             Console.Write(randomChar);  
//         Console.WriteLine();  
//     }
//     Console.ReadLine();
//     PauseAction();
// }

static void SayInvalid() {
    System.Console.WriteLine("Invalid choice");
    PauseAction();
}

static void RouteEm(int userChoice) {
    if(userChoice==1){
        GetFull();
    }
    else if(userChoice==2){
        //GetPartial();
    }
    else if(userChoice!=3){
        SayInvalid();
    }
}

static void PauseAction() {
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

// Random rnd = new Random();
// Int number = rnd.Next(2);​
// (Returns a number between 0-1)