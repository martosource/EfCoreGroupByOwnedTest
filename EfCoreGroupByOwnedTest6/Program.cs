
using EfCoreGroupByOwnedTest6;
using Microsoft.EntityFrameworkCore;

var context = new TestContext();


context.Database.EnsureCreated();


var query = context.Items
    .GroupBy(x => x.Group)
    .Select(x => new
    {
        Set1Value1 = x.Sum(v => v.Set1.Value1),
        Set1Value2 = x.Sum(v => v.Set1.Value2),
        Set2Value1 = x.Sum(v => v.Set2.Value1),
        Set2Value2 = x.Sum(v => v.Set2.Value2),
    });

Console.WriteLine(query.ToQueryString());

System.Diagnostics.Trace.WriteLine(query.ToQueryString());


