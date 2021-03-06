package org.o7planning.hellospringmvc.controller;

import java.util.ArrayList;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpSession;

import org.o7planning.hellospringmvc.bean.SinhVien_LNTribean;
import org.o7planning.hellospringmvc.bo.SinhVien_LNTribo;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class Ht_LNTri {
	@RequestMapping("/Ht_LNTri")
	public ModelAndView  htsinhvien(Model model, HttpServletRequest request, HttpSession session, HttpServletRequest response) {
		try {
			 response.setCharacterEncoding("utf-8");
				request.setCharacterEncoding("utf-8");
				SinhVien_LNTribo sv = new SinhVien_LNTribo();
		 	String key= request.getParameter("txtfind");
		 	ArrayList<SinhVien_LNTribean> dssv= sv.getsv();
		 	if(key==null)
		 		return new ModelAndView("Timkiem_LNTri");
		 	
		 	else {
		   			dssv=sv.Tim(dssv, key);
		   			if (dssv!=null) 
		   		session.setAttribute("dssv", dssv);
		   	
		   		
		   		 return new ModelAndView("Ht_LNTri");
		   	
		   		
		   			}
		   		
		} catch (Exception e) {
			e.printStackTrace();
			return null;
		}
		
		
	}
}
