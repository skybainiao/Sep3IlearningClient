package Database;

import Model.Group;
import java.sql.*;

public class JDBC {

  private static String driver = "org.postgresql.Driver";
  private static String url = "jdbc:postgresql://localhost:5432/postgres";
  private static String user = "postgres";
  private static String password = "cjj2468830035";
  private Connection connection;

  public JDBC() throws ClassNotFoundException, SQLException
  {
    Class.forName(driver);
    connection = DriverManager.getConnection(url,user,password);
    System.out.println("Connected to database : "+connection.getCatalog());
  }


  public int addUser(String username,String password) throws SQLException
  {
    String sql = "insert into sep3data.SimpleUser(username,password)\n" + "values (?,?)";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,username);
    preparedStatement.setString(2,password);

    return preparedStatement.executeUpdate();
  }


  public ResultSet getAllUsers() throws SQLException
  {
    String sql = "select * from sep3data.SimpleUser";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);

    return preparedStatement.executeQuery();
  }


  public int addLecturerAccount(String LecturerName,String username,String password) throws SQLException
  {
    String sql = "insert into sep3data.LecturerAccount(lecturerName, username, password)\n" + "values (?,?,?)";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,LecturerName);
    preparedStatement.setString(2,username);
    preparedStatement.setString(3,password);

    return preparedStatement.executeUpdate();
  }


  public ResultSet getAllLecturerAccount() throws SQLException
  {
    String sql = "select * from sep3data.LecturerAccount";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);

    return preparedStatement.executeQuery();
  }


  public int sendMessage(String senderName,String receiveName,String text) throws SQLException {

    String sql="insert into sep3data.Message(senderName,receiveName,chatMessages)\n" + "values(?,?,?)";
    PreparedStatement preparedStatement=connection.prepareStatement(sql);
    preparedStatement.setString(1, senderName);
    preparedStatement.setString(2, receiveName);
    preparedStatement.setString(3,text);

    return preparedStatement.executeUpdate();
  }


  public ResultSet getAllMessages1() throws SQLException
  {
    String sql = "select * from sep3data.Message;";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);

    return preparedStatement.executeQuery();
  }


  public ResultSet getMessage(String senderName,String receiveName) throws SQLException {
    String sql="select *\n" + "from sep3data.Message\n" +
        "where senderName = ? and receiveName = ?\n" +
        "or senderName = ? and receiveName = ?";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,senderName);
    preparedStatement.setString(2,receiveName);
    preparedStatement.setString(3,receiveName);
    preparedStatement.setString(4,senderName);

    return preparedStatement.executeQuery();
  }


  public ResultSet getAllMessage(String receiver) throws SQLException
  {
    String sql = "select *\n" + "from sep3data.Message\n" + "where receiveName = ?";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,receiver);

    return preparedStatement.executeQuery();
  }


  public ResultSet getFriends(String username) throws SQLException {
    String sql="select friendName from sep3data.Friend where username = ?";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,username);

    return preparedStatement.executeQuery();
  }
  public int increase(String username) throws SQLException {
    String sql="update sep3data.SimpleUser set receiveMessageNum = receiveMessageNum+1 where username = ?";
    PreparedStatement preparedStatement=connection.prepareStatement(sql);
    preparedStatement.setString(1,username);

    return preparedStatement.executeUpdate();
  }


  public ResultSet getUnreadNum(String username) throws SQLException
  {
    String sql = "select receiveMessageNum\n" + "from sep3data.SimpleUser\n" + "where username = ?";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1, username);

    return preparedStatement.executeQuery();
  }


  public int addFriend(String username,String fiendName) throws SQLException
  {
    String sql = "insert into sep3data.Friend(username, friendName)\n" + "values (?,?)";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,username);
    preparedStatement.setString(2,fiendName);

    return preparedStatement.executeUpdate();
  }


  public int clearMessage(String username) throws SQLException
  {
    String sql = "update sep3data.SimpleUser set receiveMessageNum = 0 where username = ?";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,username);
    return preparedStatement.executeUpdate();

  }


  public int sendFriendRequest(String sender,String receiver,String comment) throws SQLException
  {
    String sql = "insert into sep3data.FriendRequest(sender, receiver, comment)\n" + "values (?,?,?)";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,sender);
    preparedStatement.setString(2,receiver);
    preparedStatement.setString(3,comment);

    return preparedStatement.executeUpdate();
  }


  public ResultSet getRequest(String username) throws SQLException
  {
    String sql = "select * from sep3data.FriendRequest where receiver = ?";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,username);

    return preparedStatement.executeQuery();
  }


  public int deleteRequest(String sender,String receiver) throws SQLException
  {
    String sql = "delete from sep3data.FriendRequest where sender = ? and receiver = ?";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,sender);
    preparedStatement.setString(2,receiver);

    return preparedStatement.executeUpdate();
  }


  public int addProfile(String username,String firstName,String lastName,String email,String phoneNumber,String country,String age,String sex) throws SQLException
  {
    String sql = "insert into sep3data.Profile(username, firstName, lastName, email, phoneNumber, country,age,sex)\n" + "values (?,?,?,?,?,?,?,?)";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,username);
    preparedStatement.setString(2,firstName);
    preparedStatement.setString(3,lastName);
    preparedStatement.setString(4,email);
    preparedStatement.setString(5,phoneNumber);
    preparedStatement.setString(6,country);
    preparedStatement.setString(7,age);
    preparedStatement.setString(8,sex);

    return preparedStatement.executeUpdate();
  }


  public ResultSet getProfile() throws SQLException
  {
    String sql = "select * from sep3data.Profile";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);

    return preparedStatement.executeQuery();
  }


  public int deleteProfile(String username) throws SQLException
  {
    String sql = "delete from sep3data.Profile where username = ?";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,username);

    return preparedStatement.executeUpdate();
  }


  public ResultSet getCourses(String courseName) throws SQLException
  {
    String sql = "select *\n" + "from sep3data.Course\n" + "where courseName = ?";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,courseName);

    return preparedStatement.executeQuery();
  }


  public ResultSet getAnnouncement(String courseName) throws SQLException
  {
    String sql = "select *\n" + "from sep3data.Announcement\n" + "where courseName = ?";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,courseName);

    return preparedStatement.executeQuery();
  }


  public ResultSet getAllAnnouncement() throws SQLException
  {
    String sql = "select *\n" + "from sep3data.Announcement";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);

    return preparedStatement.executeQuery();
  }


  public ResultSet getAllMoments() throws SQLException
  {
    String sql = "select * from sep3data.Moment;";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);

    return preparedStatement.executeQuery();
  }


  public int addMoment(String username,String time,String content,int likeNum,int dislike)
      throws SQLException
  {
    String sql = "insert into sep3data.Moment(username, time, content, likeNum, dislike)\n" + "values (?,?,?,?,?)";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,username);
    preparedStatement.setString(2,time);
    preparedStatement.setString(3,content);
    preparedStatement.setInt(4,likeNum);
    preparedStatement.setInt(5,dislike);

    return preparedStatement.executeUpdate();
  }


  public int like(String username) throws SQLException
  {
    String sql = "update sep3data.Moment set likeNum = likeNum+1 where username = ?";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,username);

    return preparedStatement.executeUpdate();
  }


  public int dislike(String username) throws SQLException
  {
    String sql = "update sep3data.Moment set dislike = dislike+1 where username = ?";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,username);

    return preparedStatement.executeUpdate();
  }


  public int addComment(String username,String publisher,String content,String time) throws SQLException
  {
    String sql = "insert into sep3data.Comment(username, publisher, content, time)\n" + "values (?,?,?,?)";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,username);
    preparedStatement.setString(2,publisher);
    preparedStatement.setString(3,content);
    preparedStatement.setString(4,time);

    return preparedStatement.executeUpdate();
  }


  public ResultSet getComments(String username,String publisher,String time) throws SQLException
  {
    String sql = "select * from sep3data.Comment where username = ? and publisher = ? and time = ?";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,username);
    preparedStatement.setString(2,publisher);
    preparedStatement.setString(3,time);

    return preparedStatement.executeQuery();
  }


  public ResultSet getGroups() throws SQLException
  {
    String sql = "select * from sep3data.Groups";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);

    return preparedStatement.executeQuery();
  }


  public ResultSet getGroupName() throws SQLException
  {
    String sql = "select groupName\n" + "from sep3data.Groups\n" + "group by groupName;";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);

    return preparedStatement.executeQuery();
  }


  public int addGroup(Group group) throws SQLException
  {
    String sql = "insert into sep3data.Groups(groupName,memberName)\n" + "values (?,?)";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,group.getGroupName());
    preparedStatement.setString(2,group.getMemberName());

    return preparedStatement.executeUpdate();
  }


  public ResultSet getGroupMember(String username) throws SQLException
  {
    String sql = "select memberName\n" + "from sep3data.Groups\n"
        + "where groupName = (select groupName from sep3data.Groups where memberName = ?);";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,username);

    return preparedStatement.executeQuery();
  }


  public int addCourse(String courseName,String session,String date,String content,String preparation)
      throws SQLException
  {
    String sql = "insert into sep3data.Course(courseName, session, date, content,preparation)\n" + "values (?,?,?,?,?)";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,courseName);
    preparedStatement.setString(2,session);
    preparedStatement.setString(3,date);
    preparedStatement.setString(4,content);
    preparedStatement.setString(5,preparation);

    return preparedStatement.executeUpdate();
  }


  public int addAnnouncement(String courseName,String LecturerName,String time,String content)
      throws SQLException
  {
    String sql = "insert into Announcement(courseName, LecturerName, time, content)\n" + "values (?,?,?,?)";
    PreparedStatement preparedStatement = connection.prepareStatement(sql);
    preparedStatement.setString(1,courseName);
    preparedStatement.setString(2,LecturerName);
    preparedStatement.setString(3,time);
    preparedStatement.setString(4,content);

    return preparedStatement.executeUpdate();
  }


}
