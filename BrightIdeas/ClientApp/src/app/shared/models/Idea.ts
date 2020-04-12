export default class Idea {
  ideaId: number;
  description: string;
  creatorUserId: number;
  leaderUserId: number;
  mediaId: number;
  updateId: number;
  dateTime: Date = new Date();
  toDoList: Array<number>;
  ideaMembers: Array<number>;
  ideaReports: Array<number>;
}
