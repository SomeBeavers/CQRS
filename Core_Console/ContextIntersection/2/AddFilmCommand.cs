﻿using Core_Console.DB;
using JetBrains.Annotations;
using MediatR;
using  X =  Core_Console.ContextIntersection.StaticCommand;

namespace Core_Console.ContextIntersection;


public class AddFilmQuery: IRequest<Film>, IAddBaseQuery<int>
{
    public int Id { get; set; }
    public string Name { get; set; }


    void IAddBaseQuery<int>.Add(int id)
    {
        Test();
    }
    
    private void Test()
    {
        throw new NotImplementedException();
    }

    public AddFilmQuery GetThis()
    {
        throw new NotImplementedException();
    }
}

public class MyCommand
{
    public AddFilmQuery MyProperty{ get; set; } = new AddFilmQuery().GetThis();
    public void Test(MyEnum myEnum)
    {
        var addFilmQuery = MyProperty;
        new GetFilmQuery().Test2();
        //switch (myEnum)
        //{
        //    case MyEnum.Test:
        //        new AddFilmQuery().GetThis();
        //        break;
        //    case MyEnum.Test2:
        //        break;
        //    default:
        //        new AddFilmQuery().GetThis();
        //        throw new ArgumentOutOfRangeException(nameof(myEnum), myEnum, null);
        //}

        //((IAddBaseQuery<int>)new AddFilmQueryImpl()).Add(0);
    }
}

public enum MyEnum
{
    Test,
    Test2
}

public class AddFilmQueryImpl : AddFilmQuery
{
    public void Add(int id)
    {
    }

    public AddFilmQueryImpl()
    {
        Id = 0;
        Name = "";
    }
}


public partial class GetFilmQuery : IAddBaseQuery<int>
{
    void IAddBaseQuery<int>.Add(int id)
    {
        X.Test();
        Test();
    }

    private void Test()
    {
        throw new NotImplementedException();
    }
}

public partial class GetFilmQuery
{
    public void Test2()
    {
        StaticCommand.Test();
    }

}

public interface IAddBaseQuery<T>
{
    public void Add(T id);
}

public static class StaticCommand
{
    public static void Test()
    {
        throw new NotImplementedException();
    }
}