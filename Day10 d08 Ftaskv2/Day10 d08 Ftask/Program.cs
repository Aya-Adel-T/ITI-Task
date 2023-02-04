using Day10_d08_Ftask;

#region Array For True or False Q we did not use
QTrueFalse[] qRRTrueFalse = new QTrueFalse[5];
QTrueFalse q1 = new QTrueFalse("Q1 Write A for True and B for False\n1- Egypt is a country", "A- True B- False", 5, new AnswerTrueFalse("A"));
qRRTrueFalse[0] = q1;
QTrueFalse q2 = new QTrueFalse("Q1 Write A for True and B for False\n2- Humans have 3 hands", "A- True B- False\"", 5, new AnswerTrueFalse("B"));
qRRTrueFalse[1] = q2;
QTrueFalse q3 = new QTrueFalse("Q1 Write A for True and B for False\n3- You cry using your ears", "A- True B- False\"", 5, new AnswerTrueFalse("B"));
qRRTrueFalse[2] = q3;
QTrueFalse q4 = new QTrueFalse("Q1 Write A for True and B for False\n4- Flowers are plants", "A- True B- False\"", 5, new AnswerTrueFalse("A"));
qRRTrueFalse[3] = q4;
QTrueFalse q5 = new QTrueFalse("Q1 Write A for True and B for False\n5- I love Egypt ", "A- True B- False\"", 5, new AnswerTrueFalse("B"));
qRRTrueFalse[4] = q5;
#endregion

List<QTrueFalse> qLTrueFalses = new List<QTrueFalse>()
{
    new QTrueFalse("Q1 Write A for True and B for False\n1- Egypt is a country","A- True B- False",5,new AnswerTrueFalse ("A")),
    new QTrueFalse("Q1 Write A for True and B for False\n2- Humans have 3 hands","A- True B- False\"",5,new AnswerTrueFalse ("B")),
    new QTrueFalse("Q1 Write A for True and B for False\n3- You cry using your ears","A- True B- False\"",5,new AnswerTrueFalse ("B")),
    new QTrueFalse("Q1 Write A for True and B for False\n4- Flowers are plants","A- True B- False\"",5,new AnswerTrueFalse("A")),
    new QTrueFalse("Q1 Write A for True and B for False\n5- I love Egypt ","A- True B- False\"",5,new AnswerTrueFalse ("B"))
};
List<QChooseOne> qLChooseOnes = new List<QChooseOne>()
{
    new QChooseOne("Q2 Choose A B C or D","We have (A) 2 - B) 4 -c) 8 -D) 6) legs",5,   new AnswerChooseOne ("A")),
    new QChooseOne("Q2 Choose A B C or D","Humans live on (A) Moon-B) Earth-c) Sky-D) drugs) ",5,  new AnswerChooseOne ("B")),
    new QChooseOne("Q2 Choose A B C or D","pens are for (A) reading-B) singing-C) writing-D) dancing",5,new AnswerChooseOne ("C")),
    new QChooseOne("Q2 Choose A B C or D","the sun color is (A)green - B)orange - C)black - D)f7lo2i) ",5 ,new AnswerChooseOne ("B")),
    new QChooseOne("Q2 Choose A B C or Dr","2+4 = (A)8 - B)12 - c)3 - D)6) ",5 ,new AnswerChooseOne ("D"))
};
List<QChooseMul> qLChooseMuls = new List<QChooseMul>()
{
    new QChooseMul("Q3 Choose A-B or A-B-C or A-B-D or A-C or A-C-D or A-D or A-D-A..etc","we can eat (A) apples B) bananas C) ourselves D) meat)",5, new AnswerChooseMul ("A-B-D")),
    new QChooseMul("Q3 Choose A-B or A-B-C or A-B-D or A-C or A-C-D or A-D or A-D-A..etc","Where do the lions live (A) zoo - B) cage - C) Sky - D) forest) ",5, new AnswerChooseMul ("A-B-D")),
    new QChooseMul("Q3 Choose A-B or A-B-C or A-B-D or A-C or A-C-D or A-D or A-D-A..etc","choose 3 Animals (A) Dog - B) someone you know - C) Panda - D) Cat) ",5,new AnswerChooseMul ("A-C-D")),
    
};

int ExamType;
do
{
    Console.WriteLine("Choose 1 for Practical Exam and 2 for Final Exam");
    int.TryParse(Console.ReadLine(), out ExamType);
} while ( ExamType != 1   && ExamType !=2);


if (ExamType == 1)
{
    Console.WriteLine("This is a Practical Exam");
    PracticalExam pracexam = new PracticalExam(13, 60, qLTrueFalses, qLChooseOnes, qLChooseMuls/*, "Q1 answers */);
    pracexam.TakeExam();

}
else
{
    Console.WriteLine("This is the Final Exam");
    FinalExam fexam = new FinalExam (13, 30, qLTrueFalses, qLChooseOnes, qLChooseMuls);
    fexam.TakeExam();
}


