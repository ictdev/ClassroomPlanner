namespace ClassroomPlannerApp.Shared.Responses
{
    public class ApiErrorResponse
    {
        public string Message { get; set; }
        public string[] Errors { get; set; }
        public bool isSuccess { get; set; }

    }
}
