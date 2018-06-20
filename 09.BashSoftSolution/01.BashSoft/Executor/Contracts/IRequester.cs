﻿using System;
using System.Collections.Generic;
using System.Text;

public interface IRequester
{
    void GetStudentScoresFromCourse(string courseName, string username);

    void GetAllStudentsFromCourse(string courseName);

    ISimpleOrderedBag<ICourse> GetAllCoursesSorted(IComparer<ICourse> cmp);

    ISimpleOrderedBag<IStudent> GetAllStudentsSorted(IComparer<IStudent> cmp);
}