﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZhaoQi.Common
{
    public class FilterCondition
    {
        public enum RelationType
        {
            And,
            Or,
            AndBracket,
            CloseBracket,
            OrBracket
        }

        public enum ActionType
        {
            LikeStart,
            LikeEnd,
            Equal,
            NotEqual,
            LessThanAndEqual,
            LessThan,
            GreaterThanAndEqual,
            GreaterThan,
            In,
            NotIn
        }

        public RelationType Relation { get; set; }
        public ActionType Action { get; set; }
        public string Value { get; set; }
        public string Name { get;set;}
    }


    




}
