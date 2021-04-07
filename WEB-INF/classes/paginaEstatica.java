

import java.io.*;
import javax.servlet.*;
import javax.servlet.http.*;
import java.lang.String;
import java.util.*;

/**
 * Servlet implementation class paginaEstatica
 */
public class paginaEstatica extends HttpServlet {
	private static final long serialVersionUID = 1L;
       

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String fichero = request.getServletContext().getRealPath("pagina_literal.html");
		String linea;
		Calendar calendario = Calendar.getInstance();
		Date fecha = calendario.getTime();
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
        FileReader f = new FileReader(fichero);
        BufferedReader b = new BufferedReader(f);
        while((linea = b.readLine())!=null) {
        	if(linea.contains("poned_aqui_la_fecha_y_los_nombres")) {
        		out.println("<p>Hoy es " +fecha +" , y somos Jaime Martínez Sánchez y Marcos Haba Claramunt");
        	}
        	else {
            out.println(linea);
        	}
        }
	    b.close();
		}
	}
