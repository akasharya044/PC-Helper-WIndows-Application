
namespace custos.services.Services
{
    public class TicketRecord
	{
		public int Id { get; set; }
		public string? Description { get; set; }
		public string? EntityType { get; set; }
		public string? ServiceDeskGroup { get; set; }
		public string? RegisteredForActualService { get; set; }
		public string? RequestedByPerson { get; set; }
		public string? Priority { get; set; }
		public int? RegisteredForDevice_c { get; set; }
		public int? ONGCCAT_c { get; set; }
		public int? ONGCSUB_c { get; set; }
		public int? ONGCAREA_c { get; set; }
		public int? ContactPerson { get; set; }
		public string? DisplayLabel { get; set; }
		public bool? TicketGenerated { get; set; } //If not generated reprocess it in handler
		public int? TicketId { get; set; }
		public int? TicketStatus { get; set; }//0 pending,1 ticket generated,2 resolved,3 feedback received
		public int? FeedbackCount { get; set; } = 0;
		public bool? FeedBackReceived { get; set; } = false;
		public DateTime? FeedBackReceivedOn { get; set; }
		public DateTime? NextFeedBackSchedule { get; set; }
		public DateTime CreatedDateTime { get; set; } = DateTime.Now;
		public DateTime? ResolvedDateTime { get; set; }
		public DateTime? LastUpdateTime { get; set; }
		public string? SystemId { get; set; } //New field added 
		public string? AssignedTo { get; set; }
		public string? FeedBackRemark { get; set; }
		public string? Completion_status { get; set; }
		public int starcount { get; set; }
		//get resonse
		public string? CurrentStatus_c { get; set; }
		public string? ExpertAssignee { get; set; }
		public string? ExpertAssigneeName { get; set; }
		public string? RequestedByPersonName { get; set; }
		public string? RegisteredForLocation { get; set; }
		public int close_count { get; set; }
		//update 
		public string? feedback_status { set; get; }
		public string? feedback_comment { set; get; }
		public string? feedback_action { set; get; }
		public string? feedback_rating { set; get; }
		public string? Region { get; set; }
		public string? Severity {  get; set; }
		public string? Location {  get; set; }
	}
	public class UpdateTicket
	{
		public int IncidentId { get; set; }
		public string action { get; set; }
		public int starcount { get; set; }
		public string? Remarks { get; set; }
	}

	public class RaiseMFTicketDTO
	{
		public List<MFEntity> entities { get; set; }
		public string operation { get; set; }
	}
	public class MFEntity
	{
		public string entity_type { get; set; }
		public MFProperty properties { get; set; }
	}
	public class MFProperty
	{
		public string ServiceDeskGroup { get; set; }
		public string Description { get; set; }
		public string RegisteredForActualService { get; set; }
		public string RequestedByPerson { get; set; }
		public string Priority { get; set; }
		public string ONGCCAT_c { get; set; }
		public string ONGCSUB_c { get; set; }
		public string ContactPerson { get; set; }
		public string DisplayLabel { get; set; }
	}
}
