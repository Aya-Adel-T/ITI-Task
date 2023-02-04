namespace Day10_d08_Ftask
{
    public abstract class Question
    {
        public  string Header { get; set; }
        public  string Body { get; set; }
        public  int Marks { get; set; }
        public Question(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
        }

    }
    public class QTrueFalse : Question
    {
        public AnswerTrueFalse AnswerTF { get; set; }
        public QTrueFalse(string header, string body, int marks,AnswerTrueFalse answers) :base( header,  body,  marks)
        {
            AnswerTF = answers;

        }
    }
    public class QChooseOne : Question
    {
       
        public AnswerChooseOne AnswerChOne { get; set; }

        public QChooseOne(string header, string body, int marks, AnswerChooseOne answers):base( header, body, marks)
        {
            AnswerChOne = answers;

        }
       
    }
    public class QChooseMul : Question
    {

        public AnswerChooseMul AnswerChmul { get; set; }

        public QChooseMul(string header, string body, int marks, AnswerChooseMul answers) : base(header, body, marks)
        {
            AnswerChmul = answers;

        }

    }

}
