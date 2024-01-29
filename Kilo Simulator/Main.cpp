#include <iostream>
#include <string>

using namespace std;

int main() {
    // TUTORIAL
    cout << "*----------------------------------------------------------------------------------------------*" << endl;
    cout << "| WELCOME TO GUESS THE OBEZ GAME!!                                                             |" << endl;
    cout << "| How the game works: You need to guess the weight and height of the character.                |" << endl;
    cout << "| There will be 7 options for each attribute. Choose wisely! Good luck soldier!                |" << endl;
    cout << "| Select your character. You'll need to guess their weight and height.                         |" << endl;
    cout << "*----------------------------------------------------------------------------------------------*" << endl << endl << endl << endl << endl;

    // CHARACTER SELECTION
    int characterChoice;

    cout << "Pick your character." << endl << endl << endl << endl;
    cout << "1. Arda Neva  (character 1)" << endl << endl;
    cout << "2. Kuzey Bred (character 2)" << endl << endl;
    cout << "3. Omer Spix  (character 3)" << endl << endl;
    cout << "4. Emir Darzy (character 4)" << endl << endl;
    cout << "5. Emre Lucid (character 5)" << endl << endl;

    cout << "Enter the number of your chosen character: ";
    cin >> characterChoice;

    int weight, height;
    string question;

    // Check the user's character choice and set the weight, height, and question accordingly
    switch (characterChoice) {
    case 1:
        cout << "You chose Arda Neva." << endl << endl << endl
            << "According to a rumor, Arda was a person who was borderline obese (almost obese but not) but even he was, he didn't really care" << endl << endl
            << "people were starting gossiping about his posture. they were saying that Arda was sitting skewed. But Arda wasn't careing about it anyways, " << endl << endl
            << "he were started smoking and his mom were had a job. So if he doesn't cook, he couldn't eat. Arda was choosing staying hungry instead, so Arda was loosing weights as much as Omer Kaan" << endl << endl
            << "Last time Arda was seen by Emir Darzy at Kusadasi. Emir said that Arda was so skinny." << endl
            << "----------------------------------------------------------------------------------------------" << endl << endl << endl
            << "READ STORY LINE BEFORE YOU START!!" << endl;

        weight = 76;
        height = 183;
        question = "Guess Arda Neva's weight:\nA) 110(OBEZITE)\nB) 40(\nC) 76\nD) 571\nE) 95(OBEZITE SINIRI)\nF) 120\nG) 55";
        break;
    case 2:
        cout << "You chose Kuzey Bred." << endl << endl << endl
            << "According to a rumor, Kuzey was a very thin person, so thin that his bones were visible." << endl << endl
            << "Kuzey was known to always make fun of his friends without looking at his own appearance." << endl << endl
            << "The latest rumor was that Kuzey's brain turned into bone and he died." << endl
            << "----------------------------------------------------------------------------------------------" << endl << endl << endl
            << "READ STORY LINE BEFORE YOU START!!" << endl;
        weight = 60;
        height = 175;
        question = "Guess Kuzey Bred's weight:\nA) 188\nB) 24(rumor kilogram)\nC) 60\nD) 55(my shoe size)\nE) 70\nF) 100\nG) 45";
        break;
    case 3:
        cout << "You chose Omer Spix." << endl << endl << endl
            << "According to a rumor, Omer was a person who was severely obese. One day he" << endl << endl
            << "got tired of it and decided to lose weight. He died after losing 40 kilograms of weight in just 2 days." << endl << endl
            << "The last time Omer weighed himself, he was 60 kilograms..." << endl
            << "----------------------------------------------------------------------------------------------" << endl << endl << endl
            << "READ STORY LINE BEFORE YOU START!!" << endl;
        weight = 68.9;
        height = 186;
        question = "Guess Omer Spix's weight:\nA) 152\nB) 193\nC) 68.9(GUNCEL DATA MUBAREK)\nD) 13\nE) 21\nF) 2\nG) 5";
        break;

    case 4: // Yeni karakter
        cout << "You chose Emir Darzy." << endl << endl << endl
            << "According to a rumor, Emir was a person that traumatised by his passed most like childhood." << endl << endl
            << "He has really bad past with his dad and mom because their drug addict. He was happy when he didn't knew that his parents were using drugs, but when he learned, a lot changed him." << endl << endl
            << "He was earning happines from eating but even his life has this changes he was still happy with his Fortnite friends and etc. After and after eating, he became almost like Arda at some point." << endl << endl
            << "Then ofcourse he got bullied by Kuzey and others, he was mad.. he decided to get his FLAWLESS REVENGE. He bought an subscripton for an gym and he started pumping. He was getting better and better." << endl << endl
            << "And after a time passes he became gym rat, he was also used creatine and he was much more good than before. at the end, he got his revenge..." << endl
            << "----------------------------------------------------------------------------------------------" << endl << endl << endl
            << "READ STORY LINE BEFORE YOU START!!" << endl;
        weight = 75; // Değiştirilebilir
        height = 175; // Değiştirilebilir
        question = "Guess Emir Darzy's weight:\nA) 20(KUZ- NEYSE)\nB) 85(BILEMICEM OLABILIR BELKI)\nC) 75\nD) 90(KASLI MASLI FENASAL)\nE) 1453 ISTANBULUN FETHI\nF) 95\nG) 88";
        break;
    case 5: // Yeni karakter
        cout << "You chose Emre Lucid." << endl
            << "According to a rumor, Emre is lighter than a feather." << endl
            << "he may be at his 20's but even how sharp he looks he is a bit lower and thinner than Kuzey." << endl
            << "He's not a fan of foods. he eats average." << endl
            << "----------------------------------------------------------------------------------------------" << endl << endl << endl
            << "READ STORY LINE BEFORE YOU START!!" << endl;
        weight = 55;
        height = 172;
        question = "Guess Emre Lucid's weight:\nA) 100\nB) 120(OMER KAAN SIZE)\nC) 55\nD) 20(KUZEY)\nE) 60\nF) 85\nG) 72";
        break;
    default:
        cout << "ADAM AKILLI OYNAMASINI BILMIYORSAN OYNAMA. SURAYA SAYI YAZACAN SAYI!" << endl;
        return 0; // Geçersiz karakter seçimi durumunda oyunu sonlandır
    }

    // Oyuncunun tahminleri
    string guessedWeight;
    int weightOption;
    int guessedHeight;

    cout << question << " for " << characterChoice << ": ";
    cin >> guessedWeight;

    if (guessedWeight == "A" || guessedWeight == "a") {
        weightOption = 1;
    }
    else if (guessedWeight == "B" || guessedWeight == "b") {
        weightOption = 2;
    }
    else if (guessedWeight == "C" || guessedWeight == "c") {
        weightOption = 3;
    }
    else if (guessedWeight == "D" || guessedWeight == "d") {
        weightOption = 4;
    }
    else if (guessedWeight == "E" || guessedWeight == "e") {
        weightOption = 5;
    }
    else if (guessedWeight == "F" || guessedWeight == "f") {
        weightOption = 6;
    }
    else if (guessedWeight == "G" || guessedWeight == "g") {
        weightOption = 7;
    }
    else {
        cout << "AFERIM ILK TURKCE EASTER EGGI DE BULDUN. SEN SINAVDA SIKKI" << endl << "ISARETLEMEK YERINE GIDIP SIKKIN UZERINE TEKRAR CEVABI MI YAZIYON?" << endl;
        return 1; // Geçersiz seçenek durumunda oyunu sonlandır
    }

    cout << "Guess the height (in cm) of " << characterChoice << ": ";
    cin >> guessedHeight;

    // Karakterin gerçek bilgileri ile oyuncunun tahminlerini karşılaştırma
    if (weightOption == 3 && guessedHeight == height) {
        cout << "Congratulations! YOU MADE IT TO ESCAPE SIMULATION ALIVE!" << endl;
    }
    else {
        cout << "YOU GAINED 999 MORE KILOGRAMS INSTANTLY. YOU WERE SCARED, DIDN'T UNDERSTAND WHAT WAS HAPPENING, AND YOU TRIED TO RUN. YOU DIED FROM A HEART ATTACK. -- RIGHT ANSWER IS " << to_string(weight) << " KILOGRAMS AND ALSO HE IS " << height << " cm." << endl;
    }

    return 0;
}