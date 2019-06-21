﻿using najjar.biz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace najjar.biz.ViewModels
{
    public class QuestionModel
    {
        public int TotalQuestionInSet { get; set; }
        public int QuestionNumber { get; set; }
        public int TestId { get; set; }
        public int DurationInMinutes { get; set; }
        public string TestName { get; set; }
        public string Question { get; set; }
        public string QuestionType { get; set; }
        public double Points { get; set; }
        public List<QXOModel> Options { get; set; }

        public DateTime ExpiryDate { get; set; }
    }

    public class QXOModel
    {
        public int ChoiceId { get; set; }
        public string Label { get; set; }
        public string Answer { get; set; }
    }
}