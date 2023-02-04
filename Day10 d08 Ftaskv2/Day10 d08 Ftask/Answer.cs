namespace Day10_d08_Ftask
{
    public class Answer
    {
        public string Answers { get; set; }
        public Answer(string answers)
        {
            Answers = answers;
        }

    }

    public class AnswerTrueFalse : Answer
    {
        public AnswerTrueFalse(string answers) : base(answers)
        {

        }
    }
    public class AnswerChooseOne : Answer
    {
        public AnswerChooseOne(string answers) : base(answers)
        {

        }
    }
    public class AnswerChooseMul : Answer
    {
        public AnswerChooseMul(string answers) : base(answers)
        {

        }
    }
}
