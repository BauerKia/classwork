package com.gamblerapi;

// controlles contain mathods that handle http requests
//when the server recievesa request
//      it will route it to the approiate controller
import com.gamblerapi.dao.GamblerDAO.GamblerMemoryDao;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController  // his annotation indicates that this class
            // contains REST a  controller methods
// REST stands for Representational State Transfer
//Its just a protocal for communication between client and server
// REST is an architectural style related for designing networked applicationa
public class GamblerController {
   private GamblerMemoryDao gamblerDao;

   //CSTR
   public GamblerController(){
       this.gamblerDao = new GamblerMemoryDao();
   }

   //Define
    @GetMapping
    public String methodNameIsImportant(){
return "Welcome to Gambler API"
    }

    @GetMapping("/gamblers")
    public List<Gambler> getAllGamblers(){
       //Call the DAO methd and get all gamblers and return the gamblers
        return gamblerDao.getGamblers();
           }
}

