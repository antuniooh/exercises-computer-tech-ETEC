package com.example.troca_tela;

import android.app.Activity;
import android.os.Bundle;
import android.widget.*;
import android.view.*;

public class MainActivity extends Activity {
	Button bttelaprincipal, bttela2;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		CarregarTelaPrincipal();
	}

	public void CarregarTelaPrincipal()
	{
		setContentView(R.layout.activity_main);
		bttela2 = (Button) findViewById(R.id.bttela2);
		bttela2.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				CarregarTela2();				
			}
		});
	}
	
	public void CarregarTela2()
	{
		setContentView(R.layout.activity_two);
		bttelaprincipal = (Button) findViewById(R.id.bttelaprincipal);
		bttelaprincipal.setOnClickListener(new View.OnClickListener() {
	
			@Override
			public void onClick(View v) {
				CarregarTelaPrincipal();				
			}
		});
	}
			
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}

	@Override
	public boolean onOptionsItemSelected(MenuItem item) {
		// Handle action bar item clicks here. The action bar will
		// automatically handle clicks on the Home/Up button, so long
		// as you specify a parent activity in AndroidManifest.xml.
		int id = item.getItemId();
		if (id == R.id.action_settings) {
			return true;
		}
		return super.onOptionsItemSelected(item);
	}
}
