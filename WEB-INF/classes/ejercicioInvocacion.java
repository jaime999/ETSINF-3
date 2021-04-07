import java.io.*;
import java.util.*;
import javax.servlet.*;
import javax.servlet.http.*;

/**
 * Servlet implementation class ejercicioInvocacion
 */
public class ejercicioInvocacion extends HttpServlet {
	private static final long serialVersionUID = 1L;
	void comun(HttpServletRequest request, HttpServletResponse response, String metodo) throws ServletException, IOException {
		String cadena;
		response.setContentType("text/plain");
		PrintWriter out = response.getWriter();
		
		// recuperar informacion de la sesion e imprimir
		HttpSession sesion = request.getSession(true);
		if (sesion.isNew()) cadena ="Es una invocación nueva";
		else {Date hora=new Date(sesion.getLastAccessedTime());
			cadena="Ultima invocacion fue por "+sesion.getAttribute("metodo").toString() +
					" el " + hora;}
		
		//guardar metodo para proxima invocacion
		sesion.setAttribute("metodo", metodo);
		out.println(cadena);
	}

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		comun(request, response, "GET");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		comun(request, response, "POST");
	}

}
