/*
 * Created by SharpDevelop.
 * User: Tommy
 * Date: 7/20/2017
 * Time: 3:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Management;
using System.Net.NetworkInformation;
using System.DirectoryServices;
using System.ServiceProcess;
using System.IO;

namespace manageObj
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			rbcute.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
			rbcuss.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			rbcute.Checked = true;
			
		    dtpkglist.Columns.Add("PackageName");
			dtpkglist.Columns.Add("Active");
			dtpkglist.Columns.Add("Id");
			dtpkglist.Columns.Add("ActivatedTime");
			dtpkglist.Columns.Add("CreatedTime");
			dtpkglist.Columns.Add("AutoActivate");
			dtpkglist.Columns.Add("ResetTime");
		}
		
		public static string PingHost(string host)
		{
			//string to hold our return messge
			string returnMessage = string.Empty;
			
			//create a new ping instance
			Ping pingsender = new Ping();
			
			try
			{
				PingReply pingReply = pingsender.Send( host, 100 );
				
				if( pingReply.Status == IPStatus.Success )
				{
					returnMessage = "Online";
				}
				else
				{
					returnMessage = pingReply.Status.ToString();
				}
			}
			catch (PingException ex)
			{
				returnMessage = string.Format("Connection Error: {0}", ex.Message);
			}
						
			return returnMessage;
		}
		
		private string strSelectedIws;
		
		void BtlistClick(object sender, EventArgs e)
		{
			listpackages();
			toolStripProgressBar1.Value = 0;
		}
		
		private DataTable dtpkglist = new DataTable();
		private DataRow drpkg;
		
		private void listpackages()
		{
			if( !Islbiwsselected() )
			{
				MessageBox.Show("Please select a computer.");
				return;
			}

			strSelectedIws = lbiws.SelectedItem.ToString();
			
			toolStripStatusLabel2.Text = string.Format(@"Waiting {0} reply message.",strSelectedIws);
				
			if( !string.Equals("online", MainForm.PingHost(strSelectedIws), StringComparison.OrdinalIgnoreCase) )
			{
				toolStripStatusLabel2.Text = string.Format(@"{0} is not Online.",strSelectedIws);
				return;
			}
			else
				toolStripStatusLabel2.Text = string.Empty;
			
			toolStripProgressBar1.PerformStep();
			try
			{
				dgvpkgname.DataSource = null;
				dtpkglist.Clear();
				
				ManagementClass vspClass = new ManagementClass( string.Format(@"\\{0}\root\default:VirtualSoftwarePackage",strSelectedIws) );
				ManagementObjectCollection vspCollection =  vspClass.GetInstances();
				toolStripProgressBar1.PerformStep();
				List<string> propertyname = new List<string>();
				
				foreach( PropertyData property in vspClass.Properties )
				{
					propertyname.Add( property.Name );					
				}
				
				toolStripProgressBar1.PerformStep();
				
				foreach (ManagementObject vspObject in vspCollection)
	            {
					drpkg = dtpkglist.NewRow();
					if( vspObject.GetPropertyValue("Name") != null )
						drpkg["PackageName"] = vspObject.GetPropertyValue("Name").ToString();
					if( vspObject.GetPropertyValue("Active") != null )
						drpkg["Active"] = vspObject.GetPropertyValue("Active").ToString();
					if( vspObject.GetPropertyValue("Id") != null )
						drpkg["Id"] = vspObject.GetPropertyValue("Id").ToString();
					if( vspObject.GetPropertyValue("ActivatedTime") != null )
						drpkg["ActivatedTime"] = stringtodatetime(vspObject.GetPropertyValue("ActivatedTime").ToString().Substring(0,14));
					if( vspObject.GetPropertyValue("CreatedTime") != null )
						drpkg["CreatedTime"] = stringtodatetime(vspObject.GetPropertyValue("CreatedTime").ToString().Substring(0,14));
					if( vspObject.GetPropertyValue("AutoActivate") != null )
						drpkg["AutoActivate"] = vspObject.GetPropertyValue("AutoActivate").ToString();
					if( vspObject.GetPropertyValue("ResetTime") != null )
						drpkg["ResetTime"] = stringtodatetime(vspObject.GetPropertyValue("ResetTime").ToString().Substring(0,14));
					
					dtpkglist.Rows.Add(drpkg);
	            }
				toolStripProgressBar1.PerformStep();
				dgvpkgname.DataSource = dtpkglist;
				dgvpkgname.Columns[0].Width = 335;
				dgvpkgname.Columns[1].Width = 50;
				dgvpkgname.Columns[2].Width = 40;
				dgvpkgname.Columns[3].Width = 170;
				dgvpkgname.Columns[4].Width = 170;
			}
			catch( Exception ex )
			{
				toolStripStatusLabel2.Text = "Catch error:"+ex.Message;
			}
		}
		
		private DateTime stringtodatetime(string strdate)
		{
			string formatString = "yyyyMMddHHmmss";
			DateTime dt = DateTime.ParseExact(strdate,formatString,null);
			return dt.ToLocalTime();
		}
		
		private bool Islbiwsselected()
		{
			if( lbiws.SelectedIndex == -1 )
				return false;
			else
				return true;
		}
		
		void BtactivateClick(object sender, EventArgs e)
		{
			DataGridViewRow dgvrselected = dgvpkgname.SelectedRows[0];
			try
			{
				if( string.Equals("True",dgvrselected.Cells["Active"].Value.ToString(),StringComparison.OrdinalIgnoreCase ))
				{
					toolStripStatusLabel2.Text = "Selected package is active status.";
					return;
				}
			}
			catch(Exception ex)
			{
				toolStripStatusLabel2.Text = "Line 193:"+ex.Message;
			}
			
			try
			{
				string ObjectPath = string.Format(@"\\{0}\root\default:VirtualSoftwarePackage.Id='{1}'", strSelectedIws, dgvrselected.Cells["Id"].Value.ToString() );
				ManagementObject SVSClass = new ManagementObject(ObjectPath);
				ManagementBaseObject inParams = SVSClass.GetMethodParameters("Activate");
				ManagementBaseObject outParams = SVSClass.InvokeMethod("Activate", inParams, null);
				string myResult = outParams["ReturnValue"].ToString();
				if( string.Equals( "0" , myResult , StringComparison.OrdinalIgnoreCase) )
				{
					toolStripStatusLabel2.Text = dgvrselected.Cells["PackageName"].Value.ToString()+" active successful. Workstation: "+strSelectedIws;					
					listpackages();
				}
				else
					toolStripStatusLabel2.Text = "Return: "+myResult+" "+dgvrselected.Cells["PackageName"].Value.ToString()+" active failed. Workstation: "+strSelectedIws;
				SVSClass.Dispose();
			}
			catch(Exception ex)
			{
				toolStripStatusLabel2.Text = "Line207"+ex.Message;
			}
			toolStripProgressBar1.Value = 0;
		}
		
		void LbiwsSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtdeactiClick(object sender, EventArgs e)
		{
			
			DataGridViewRow dgvrselected = dgvpkgname.SelectedRows[0];
			try
			{
				if( string.Equals("False",dgvrselected.Cells["Active"].Value.ToString(),StringComparison.OrdinalIgnoreCase ))
				{
					toolStripStatusLabel2.Text = "Selected package is deactivate status.";
					return;
				}
			}
			catch(Exception ex)
			{
				toolStripStatusLabel2.Text = "Line 193:"+ex.Message;
			}
			toolStripProgressBar1.PerformStep();
			
			try
			{
				string ObjectPath = string.Format(@"\\{0}\root\default:VirtualSoftwarePackage.Id='{1}'", strSelectedIws, dgvrselected.Cells["Id"].Value.ToString() );				
				ManagementObject SVSClass = new ManagementObject(ObjectPath);
				toolStripProgressBar1.PerformStep();
				ManagementBaseObject inParams = SVSClass.GetMethodParameters("Deactivate");
				inParams["Force"] = true;
				ManagementBaseObject outParams = SVSClass.InvokeMethod("Deactivate", inParams, null);
				toolStripProgressBar1.PerformStep();
				string myResult = outParams["ReturnValue"].ToString();
				if( string.Equals( "0" , myResult , StringComparison.OrdinalIgnoreCase) )
				{
					toolStripStatusLabel2.Text = dgvrselected.Cells["PackageName"].Value.ToString()+" deactivate successful. Workstation: "+strSelectedIws+".";
					toolStripProgressBar1.PerformStep();
					listpackages();
				}
				else
					toolStripStatusLabel2.Text = "Return: "+myResult+" "+dgvrselected.Cells["PackageName"].Value.ToString()+" deactivate failed. Workstation: "+strSelectedIws;
				SVSClass.Dispose();
			}
			catch(Exception ex)
			{
				toolStripStatusLabel2.Text = "Line207"+ex.Message;
				toolStripProgressBar1.Value = 0;
			}
			toolStripProgressBar1.Value = 0;
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = DateTime.Now.ToString();
		}
		
		void BtdeleteClick(object sender, EventArgs e)
		{
			DataGridViewRow dgvrselected = dgvpkgname.SelectedRows[0];
			string myGuid = dgvrselected.Cells["Id"].Value.ToString();
			
			try
			{
				string ObjectPath = string.Format(@"\\{0}\root\default:VirtualSoftwarePackage.Id='{1}'", strSelectedIws, myGuid);
		        ManagementObject SVSClass = new ManagementObject(ObjectPath);
		        toolStripProgressBar1.PerformStep();
		        ManagementBaseObject inParams = SVSClass.GetMethodParameters("Delete");
		        ManagementBaseObject outParams = SVSClass.InvokeMethod("Delete", inParams, null);
		        toolStripProgressBar1.PerformStep();
		        string myResult = outParams["ReturnValue"].ToString();
		        SVSClass.Dispose();
		        if( string.Equals( "0" , myResult , StringComparison.OrdinalIgnoreCase) )
				{
					toolStripStatusLabel2.Text = dgvrselected.Cells["PackageName"].Value.ToString()+" delete successful. Workstation: "+strSelectedIws+".";
					toolStripProgressBar1.PerformStep();
					listpackages();
				}
				else
					toolStripStatusLabel2.Text = "Return: "+myResult+" "+dgvrselected.Cells["PackageName"].Value.ToString()+" delete failed. Workstation: "+strSelectedIws;
			}
			catch(Exception ex)
			{
				toolStripStatusLabel2.Text = "Delete Error:"+ex.Message;
				toolStripProgressBar1.Value = 0;
			}
			toolStripProgressBar1.Value = 0;
		}
		
		void BtimportClick(object sender, EventArgs e)
		{
			if( !Islbiwsselected() )
			{
				MessageBox.Show("Please select a computer.");
				return;
			}

			strSelectedIws = lbiws.SelectedItem.ToString();
			
			string myFile = string.Format(@"\\{0}\c$\SITA\",strSelectedIws);
			OpenFileDialog dialog = new OpenFileDialog();
		    dialog.Title = "Select file";
		    dialog.InitialDirectory = @"\\smpss\d$\library\";
		    dialog.Filter = "xpf files (*.*)|*.xpf";
		    if (dialog.ShowDialog() == DialogResult.OK)
		    {
		        string sourcepath = dialog.FileName;
		        myFile = Path.Combine(myFile,dialog.SafeFileName);
		        File.Copy( sourcepath , myFile , true );		        
		    }
		    else
		    	myFile = "";
		    
		    try
		    {
			    ConnectionOptions options = new ConnectionOptions();
		        options.Impersonation = System.Management.ImpersonationLevel.Impersonate;
		        options.EnablePrivileges = true;
		        string ScopePath = string.Format(@"\\{0}\root\default", strSelectedIws);
		        toolStripProgressBar1.PerformStep();
		        ManagementScope scope = new ManagementScope( ScopePath, options);
		        scope.Connect();
		        ManagementPath myPath = new ManagementPath("VirtualSoftwarePackage");
			    ManagementClass SVSClass = new ManagementClass(scope, myPath, null);
		        ManagementBaseObject inParams = SVSClass.GetMethodParameters("Import");
		        toolStripProgressBar1.PerformStep();
		        
		        inParams["Filename"] = myFile;
		        inParams["Overwrite"] = true;
		        ManagementBaseObject outParams = SVSClass.InvokeMethod("Import", inParams, null);
		        toolStripProgressBar1.PerformStep();
		        string myResult = outParams["ReturnValue"].ToString();
		        SVSClass.Dispose();
		        if( string.Equals( "0" , myResult , StringComparison.OrdinalIgnoreCase) )
				{
					toolStripStatusLabel2.Text = myFile+" import successful. Workstation: "+strSelectedIws+".";
					toolStripProgressBar1.PerformStep();
					listpackages();
				}
				else
					toolStripStatusLabel2.Text = "Return: "+myResult+myFile+". Import failed. Workstation: "+strSelectedIws;
		    }
		    catch( Exception ex )
		    {
		    	toolStripStatusLabel2.Text = "Import Error:"+ex.Message;
		    	toolStripProgressBar1.Value = 0;
		    }
		    toolStripProgressBar1.Value = 0;
		}
		
		void BtresetClick(object sender, EventArgs e)
		{
			try
			{
				DataGridViewRow dgvrselected = dgvpkgname.SelectedRows[0];
				string strGuid = dgvrselected.Cells["Id"].Value.ToString();
				toolStripProgressBar1.PerformStep();
				string strResult = reset( strGuid , true );
				if( string.Equals( "0" , strResult , StringComparison.OrdinalIgnoreCase) )
				{
					toolStripStatusLabel2.Text = dgvrselected.Cells["PackageName"].Value.ToString()+" reset successful. Workstation: "+strSelectedIws+".";
					toolStripProgressBar1.PerformStep();
					listpackages();
				}
				else
					toolStripStatusLabel2.Text = "Return: "+strResult+". Reset failed. Workstation: "+strSelectedIws;
				toolStripProgressBar1.PerformStep();
			}
			catch( Exception ex )
			{
				toolStripStatusLabel2.Text = ex.Message;
				toolStripProgressBar1.Value = 0;
			}
			toolStripProgressBar1.Value = 0;
		}
		
		private string reset(string myGuid, bool force)
		{
	        string ObjectPath = string.Format(@"\\{0}\root\default:VirtualSoftwarePackage.Id='{1}'", strSelectedIws, myGuid);
	        ManagementObject SVSClass = new ManagementObject(ObjectPath);
	        ManagementBaseObject inParams = SVSClass.GetMethodParameters("Reset");
	        inParams["Force"] = force;
	        ManagementBaseObject outParams = SVSClass.InvokeMethod("Reset", inParams, null);
	        string myResult = outParams["ReturnValue"].ToString();
	        SVSClass.Dispose();
	        return myResult;
    	}
		
		void radioButton_CheckedChanged(object sender, EventArgs e)
		{
			string str_ouname = String.Empty;
			if( rbcute.Checked )
				str_ouname = "CUTE-WKS";
			else if( rbcuss.Checked )
				str_ouname = "CUSS-WKS";
			else
				str_ouname = "CUTE-WKS";
			
			string strsite = Environment.UserDomainName;
			lbsite.Text = "Site:"+strsite.Substring(0,3);

			string str_entry = string.Format(@"LDAP://OU={0},DC={1},DC=LOCAL",str_ouname,strsite);

		    DirectoryEntry entry = new DirectoryEntry( str_entry );    
		    DirectorySearcher mySearcher = new DirectorySearcher(entry);

		    mySearcher.Filter = (@"(objectClass=computer)");    
		    mySearcher.SizeLimit = int.MaxValue;
    		mySearcher.PageSize = int.MaxValue;
    		
    		if( rbcute.Checked )
    		{
    			lbiws.Items.Clear();
	    		foreach(SearchResult resEnt in mySearcher.FindAll())
			    {
	    			string ComputerName = resEnt.Properties["cn"][0].ToString();
	
			        if (ComputerName.Contains("CK") || ComputerName.Contains("GT") || ComputerName.Contains("BS") || ComputerName.Contains("BO") || ComputerName.Contains("XSR"))
			        {
			        	lbiws.Items.Add(ComputerName);
			        }
			    }
    		}
    		else if( rbcuss.Checked )
    		{
    			lbiws.Items.Clear();
    			foreach(SearchResult resEnt in mySearcher.FindAll())
			    {
	    			string ComputerName = resEnt.Properties["cn"][0].ToString();
	
			        if ( ComputerName.Contains("AKA") )
			        {
			        	lbiws.Items.Add(ComputerName);
			        }
			    }
    		}
		
		    mySearcher.Dispose();
		    entry.Dispose();
		}
	}
}
