using System;
using System.Collections.Generic;
using System.Linq;
using LoginExample.Models;

namespace LoginExample.Data.Impl {
public class InMemoryUserService : IUserService {
    private IList<User> users;
    private UserData _userData = new UserDataService();
    private String name;
    
    public InMemoryUserService()
    {
        users = _userData.getAllUsers().Result;
    }


    public void setName(String name)
    {
        this.name = name;
    }


    public String getName()
    {
        return name;
    }


    public User ValidateUser(string userName, string password) {
        User first = users.FirstOrDefault(user => user.Username.Equals(userName));
        setName(userName);
        if (first == null) {
            throw new Exception("User not found");
        }

        if (!first.Password.Equals(password)) {
            throw new Exception("Incorrect password");
        }

        return first;
    }
}
}