package RMIClient;

import Model.*;
import RMIServer.Server;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;
import java.sql.SQLException;
import java.util.ArrayList;

public class ClientImpl implements Client
{
  private Server server;


  public ClientImpl() throws RemoteException, NotBoundException
  {
    UnicastRemoteObject.exportObject(this,0);
    Registry registry = LocateRegistry.getRegistry("localhost",6666);
    server = (Server) registry.lookup("Server");
  }


  @Override
  public ArrayList<User> getAllUsers() throws RemoteException, SQLException
  {
    return server.getAllUser();
  }


  @Override
  public void addUser(User user) throws RemoteException, SQLException
  {
    server.addUser(user);
    System.out.println("client add");
  }


  @Override
  public void sendMessage(String senderName, String receiveName, String text) throws SQLException, RemoteException
  {
    server.sendMessage(senderName,receiveName,text);
  }


  @Override
  public ArrayList<Message> getAllMessage(String senderName, String receiveName) throws SQLException, RemoteException
  {
    return server.getAllMessage(senderName,receiveName);
  }


  @Override
  public ArrayList<User> getAllFriends(String username) throws SQLException, RemoteException
  {
    return server.getAllFriends(username);
  }


  @Override
  public void increase(String username) throws SQLException, RemoteException
  {
    server.increase(username);
  }


  @Override
  public int getNum(String username) throws SQLException, RemoteException
  {
    return server.getNum(username);
  }


  @Override
  public void addFriend(String username, String friendName) throws SQLException, RemoteException
  {
    server.addFriend(username,friendName);
  }


  @Override
  public void clearMessageNum(String username) throws SQLException, RemoteException
  {
    server.clearMessageNum(username);
  }


  @Override
  public void sendFriendRequest(String sender, String receiver, String comment) throws SQLException, RemoteException
  {
    server.sendFriendRequest(sender, receiver, comment);
  }

  @Override public ArrayList<Request> getRequest(String username)
      throws SQLException, RemoteException
  {
    return server.getRequest(username);
  }

  @Override public void addProfile(Profile profile)
      throws SQLException, RemoteException
  {
    server.addProfile(profile);
  }


  @Override public ArrayList<Profile> getProfiles()
      throws SQLException, RemoteException
  {
    return server.getProfiles();
  }


  @Override public void deleteProfile(String username)
      throws SQLException, RemoteException
  {
    server.deleteProfile(username);
  }

  @Override public void addLecturerAccount(LecturerAccount lecturerAccount)
      throws SQLException, RemoteException
  {
    server.addLecturerAccount(lecturerAccount);
  }

  @Override public ArrayList<LecturerAccount> getAllLecturerAccounts()
      throws SQLException, RemoteException
  {
    return server.getAllLecturerAccounts();
  }

  @Override public ArrayList<Message> getAllMessageByReceiver(String receiver)
      throws SQLException, RemoteException
  {
    return server.getAllMessageByReceiver(receiver);
  }

  @Override public void deleteRequest(String sender, String receiver)
      throws SQLException, RemoteException
  {
    server.deleteRequest(sender,receiver);
  }

  @Override public ArrayList<Course> getCourses(String courseName)
      throws SQLException, RemoteException
  {
    return server.getCourses(courseName);
  }

  @Override public ArrayList<Announcement> getAnnouncement(String courseName)
      throws SQLException, RemoteException
  {
    return server.getAnnouncement(courseName);
  }

  @Override public ArrayList<Moment> getAllMoments()
      throws SQLException, RemoteException
  {
    return server.getAllMoments();
  }

  @Override public void addMoment(Moment moment)
      throws SQLException, RemoteException
  {
    server.addMoment(moment);
  }

  @Override public void like(String username)
      throws SQLException, RemoteException
  {
    server.like(username);
  }

  @Override public void dislike(String username)
      throws SQLException, RemoteException
  {
    server.dislike(username);
  }

  @Override public ArrayList<Message> getAllMessagesWithoutEverything()
      throws SQLException, RemoteException
  {
    return server.getAllMessagesWithoutEverything();
  }

  @Override public void addComment(Comment comment)
      throws SQLException, RemoteException
  {
    server.addComment(comment);
  }

  @Override public ArrayList<Comment> getAllComments(String username,
      String publisher, String time) throws SQLException, RemoteException
  {
    return server.getAllComments(username, publisher, time);
  }

  @Override public ArrayList<Group> groups()
      throws SQLException, RemoteException
  {
    return server.groups();
  }

  @Override public ArrayList<String> getGroupName()
      throws SQLException, RemoteException
  {
    return server.getGroupName();
  }

  @Override public ArrayList<String> getGroupMember(String username)
      throws SQLException, RemoteException
  {
    return server.getGroupMember(username);
  }

  @Override public void addCourse(Course course)
      throws SQLException, RemoteException
  {
    server.addCourse(course);
  }

  @Override public void addAnnouncement(Announcement announcement)
      throws SQLException, RemoteException
  {
    server.addAnnouncement(announcement);
  }

  @Override public ArrayList<Announcement> getAllAnnouncement()
      throws SQLException, RemoteException
  {
    return server.getAllAnnouncement();
  }

  @Override public void addGroup(Group group)
      throws SQLException, RemoteException
  {
    server.addGroup(group);
  }

}
