using System;
using System.Threading.Tasks;


namespace RaceTo21Blazor.Shared
{
    public class PlayersNameModel
    {
        public string? Name { get; set; }

        public string playerNum1 { get; set; }
        public string playerNum2 { get; set; }
        public string playerNum3 { get; set; }
        public string playerNum4 { get; set; }
        public string playerNum5 { get; set; }
        public string playerNum6 { get; set; }
        public string playerNum7 { get; set; }
        public string playerNum8 { get; set; }

        public async Task SubmitAsync()
        {
            //PlayersNameModel = await EmployeeService.GetEmployee(int.Parse(Id));
            string NNN;

            NNN = playerNum1;
        }

        //private async Task OnFormUpdate(ChangeEventArgs args)
        //{
        //    Person updatedModel = (Person)args.Model;
        //    var updatedValue = typeof(Person).GetProperty(args.FieldName).GetValue(updatedModel);

        //    EventLogger = $"OnUpdate fired for {args.FieldName} with a new value of \"{updatedValue}\"";
        //}
    }
}
