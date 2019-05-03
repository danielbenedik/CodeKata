#include <string>
#include <iostream> 
using namespace std;

string highestScoringWord(const string &str);
int scoreOfTheWord(int& index, const string &str, int& lengthOfTheWord);



void main()
{
	string str = "daniel benedik";
	cout << highestScoringWord(str);

	system("pause");
}

string highestScoringWord(const string &str)
{
	int index = 0, saveResIndex = 0, lengthOfTheWord = 0, scoresCorrentString = 0, maxScore = 0, save_lengthOfTheWord = 0;


	while (str[index] != '\0')
	{
		scoresCorrentString = scoreOfTheWord(index, str, lengthOfTheWord);

		if (scoresCorrentString > maxScore)
		{
			maxScore = scoresCorrentString;
			saveResIndex = index - lengthOfTheWord;
			save_lengthOfTheWord = lengthOfTheWord;
		}
		lengthOfTheWord = 0;

		if (str[index] == ' ')
			index++;
	}

	string res = str.substr(saveResIndex, save_lengthOfTheWord); // the function return string obj

	return res;
}





int scoreOfTheWord(int& index,const string &str, int& lengthOfTheWord)
{

	int score = 0;

	while (str[index] != ' ' && str[index] != '\0')
	{
		score += (str[index])-'a';
		index++;
		lengthOfTheWord++;
	}
	return score;
}