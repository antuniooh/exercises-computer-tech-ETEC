package com.example.calc;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.*;
import android.view.*;
import android.app.*;

public class MainActivity extends Activity {
	EditText ednumero1, ednumero2;
	

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		ednumero1 = (EditText)findViewById(R.id.numero1);
		ednumero2 = (EditText)findViewById(R.id.numero2);
		Button btsomar = (Button)findViewById(R.id.btsomar);
		
		btsomar.setOnClickListener(new View.OnClickListener() {
			public void onClick(View arg0){
				double num1=Double.parseDouble(ednumero1.getText().toString());
				double num2=Double.parseDouble(ednumero2.getText().toString());
				double res = num1 + num2;
				
				AlertDialog.Builder dialogo = new
				AlertDialog.Builder(MainActivity.this);
				dialogo.setTitle("Aviso");
				dialogo.setMessage("Soma:" + res);
				dialogo.setNeutralButton("OK", null);
				dialogo.show();
			}
		});
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
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
