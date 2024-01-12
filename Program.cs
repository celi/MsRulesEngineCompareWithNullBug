using RulesEngine.Models;

var simpleWorkflow = await File.ReadAllTextAsync("SimpleWorkflow.json");

var input = new Input()
{
    SomeValue = null
};

Console.WriteLine($"null < 20 in dotnet: {input.SomeValue < 20}");

var ruleEngine = new RulesEngine.RulesEngine(
    new[]
    {
        simpleWorkflow
    });

var resultList = await ruleEngine.ExecuteAllRulesAsync("SimpleWorkflow", new RuleParameter("fact", input));

Console.WriteLine($"null < 20 in RulesEngine: {resultList.First().IsSuccess}");
