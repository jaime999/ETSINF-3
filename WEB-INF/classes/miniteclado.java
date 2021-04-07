

import java.io.*;
import javax.servlet.ServletException;
import javax.servlet.http.*;

/**
 * Servlet implementation class miniteclado
 */
public class miniteclado extends HttpServlet {
	private static final long serialVersionUID = 1L;
     

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		HttpSession sesion = request.getSession(true);
		sesion.setAttribute("id", "");
		String fichero = request.getServletContext().getRealPath("diseñoMiniteclado.html");
		String linea;
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		FileReader f = new FileReader(fichero);
		BufferedReader b = new BufferedReader(f);
		while((linea = b.readLine()) != null) {
			out.println(linea);
		}
		b.close();
		
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String fichero = request.getServletContext().getRealPath("diseñoMiniteclado.html");
		String linea;
		HttpSession sesion = request.getSession(true);
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		FileReader f = new FileReader(fichero);
		BufferedReader b = new BufferedReader(f);
		String tecla = request.getParameter("tecla");
		String total = "id";
		String res = (String) sesion.getAttribute(total);
		if(tecla.equals("Retroceso")) {
			if(res.length() != 0) {
				res = res.substring(0, res.length()-1);
			}
		}
		else if(tecla.equals("Espacio")) {
			res = res + " ";
		}
		else {
			res = res + tecla;
		}
		sesion.setAttribute(total, res);
		while((linea = b.readLine()) != null) {
				if(linea.contains("Comenzamos") ) {
					out.println("<p>&Uacute;ltima tecla pulsada: <strong>"+tecla+"</strong></p>");
				}
				else if(linea.contains("pulsando")){
					out.println("<p>Total escrito: <strong>'"+res+"'</strong></p>");
				}
				else {
					out.println(linea);
				}
		}
		b.close();
	}

}
