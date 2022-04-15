namespace KindeeDataSynchronizationService.Models
{
    /// <summary>
    ///K3登入模型
    /// </summary>
    public class LoginModel
	{
        public string Message { get; set; }
        public string MessageCode { get; set; }

		/// <summary>
		/// ==1,登入成功
		/// </summary>
        public string LoginResultType { get; set; }
        public bool IsLoginSuccess
        {
            get
            {
               if(LoginResultType == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}