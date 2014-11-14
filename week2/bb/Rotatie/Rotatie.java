/**
 * @(#)Rotatie.java
 *
 * Sample Applet application
 *
 * @author Bert Hoeks
 * @version 1.00 08/01/28
 */
 
import java.awt.*;
import java.applet.*;

public class Rotatie extends Applet implements Runnable
{
	private double[][] 	a	= new double[3][2];
	private double[][]	R	= new double[2][2];
	
	public void init()
	{
		a[0][0]	=    0.0;		a[0][1]	=  120.0;
		a[1][0]	= -100.0;		a[1][1]	= -100.0;
		a[2][0]	=  100.0;		a[2][1]	= -100.0;

		R[0][0]	=  0.999;		R[0][1]	= -0.045;
		R[1][0]	=  0.045;		R[1][1]	=  0.999;

		Thread	thread	= new Thread( this );
		thread.start();
	}

	public void paint(Graphics g)
	{
		for ( int n=0; n<3; n++ )
			g.fillOval( 200+(int)a[n][0], 200+(int)a[n][1], 10, 10 );
	}

	public void run()
	{
		double[]	temp	= new double[2];
		int			n, k, j;
		
		while( true )
		{
			for ( n=0; n<3; n++ )
			{
				for ( k=0; k<2; k++ )
				{
					temp[k]	= 0.0;
					for ( j=0; j<2; j++ )
						temp[k] += R[k][j] * a[n][j];
				}
				for ( k=0; k<2; k++ )
					a[n][k]	= temp[k];
			}

			try	{	Thread.sleep( 100 ); }
			catch( Exception exception ) {}

			repaint();
		}
	}
}
