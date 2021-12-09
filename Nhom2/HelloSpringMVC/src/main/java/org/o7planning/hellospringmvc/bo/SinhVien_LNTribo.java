package org.o7planning.hellospringmvc.bo;

import java.util.ArrayList;

import org.o7planning.hellospringmvc.bean.SinhVien_LNTribean;
import org.o7planning.hellospringmvc.dao.Sinhvien_LNTridao;

public class SinhVien_LNTribo {
	Sinhvien_LNTridao sdao = new Sinhvien_LNTridao();
	public ArrayList<SinhVien_LNTribean> getsv()throws Exception{
		return sdao.getsinhvien();
	}
	public ArrayList<SinhVien_LNTribean> Tim(ArrayList<SinhVien_LNTribean> ds, String key){
    	ArrayList<SinhVien_LNTribean> tam= new ArrayList<SinhVien_LNTribean>();
    	for(SinhVien_LNTribean sv: ds)
    		if(sv.getHoTen().toLowerCase().contains(key.toLowerCase())||sv.getDiachi().toLowerCase().contains(key.toLowerCase()))
    			tam.add(sv);
    	return tam;
 	
	}
}
