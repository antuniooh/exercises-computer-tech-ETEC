package com.example.progress;

import android.app.Activity;
import android.os.Bundle;
import android.os.Handler;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.*;

public class MainActivity extends Activity implements Runnable{
ProgressBar p;
Button b;
Thread t;
Handler h;
int i;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		p=(ProgressBar)findViewById(R.id.progresso);
		b=(Button)findViewById(R.id.btDownload);
		
		b.setOnClickListener(new View.OnClickListener() {
			
			public void onClick(View v){
				h=new Handler();
				t = new Thread(MainActivity.this);
				t.start();
			}});}
	public void run(){
		i=1;
		try{
			while(i<=100){
				Thread.sleep(100);
				h.post(new Runnable(){
					
					public void run(){
						p.setProgress(i++);
					}});}
		}catch(Exception e){}
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
