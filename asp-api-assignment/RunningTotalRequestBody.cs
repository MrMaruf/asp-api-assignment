namespace asp_api_assignment
{
    /// <summary>
    /// Assignment 3 mentions body in the input, therefore 
    /// I assumed user should be passing a JSON object with 
    /// number field. That's the purpose of the object.
    /// </summary>
    public class RunningTotalRequestBody
    {
        public int Number { get; set; }
    }
}
