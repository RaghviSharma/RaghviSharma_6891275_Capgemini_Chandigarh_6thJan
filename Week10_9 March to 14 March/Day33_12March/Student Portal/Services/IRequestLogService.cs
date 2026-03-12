using StudentPortal.Models;

public interface IRequestLogService
{
	void AddLog(RequestLog log);
	List<RequestLog> GetLogs();
}