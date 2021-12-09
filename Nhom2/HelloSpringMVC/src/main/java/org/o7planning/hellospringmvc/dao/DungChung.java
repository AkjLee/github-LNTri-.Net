package org.o7planning.hellospringmvc.dao;

import java.sql.Connection;
import java.sql.DriverManager;

public class DungChung {
	public Connection cn;
    public void KetNoi() throws Exception{
   	 //B1: Xac dinh hqtcsdl
   	    Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
        cn= DriverManager.getConnection("jdbc:sqlserver://DESKTOP-5E92ANP\\SQLEXPRESS:1433;databaseName=LeNguyenTri;user=sa; password=12");
        System.out.println("Da ket noi");
    }

}
