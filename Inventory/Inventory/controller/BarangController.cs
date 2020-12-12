﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Inventory.controller
{
    class BarangController
    {
        view.DataBarang view;
        model.BarangModel model;
        private Boolean hasil;
        public BarangController(view.DataBarang view)
        {
            this.view = view;
            model = new model.BarangModel();
        }

        public void selectBarang()
        {
            DataSet data = model.selectBarang();
            view.dgBarang.ItemsSource = data.Tables[0].DefaultView;
        }
        public Boolean insertBarang()
        {
            model.idbarang = Int16.Parse(view.txtIdBarang.Text);
            model.namabarang = view.txtNamaBarang.Text;
            model.idkategori = Int16.Parse(view.cmbKategori.SelectedItem.ToString());
            model.idrak = Int16.Parse(view.cmbRak.SelectedItem.ToString());
            model.satuan = view.txtSatuan.Text;
            model.stock = Int16.Parse(view.txtStock.Text);
            hasil = model.insertBarang();
            return hasil;
        }

        public Boolean updateBarang()
        {
            model.idbarang = Int16.Parse(view.txtIdBarang.Text);
            model.namabarang = view.txtNamaBarang.Text;
            model.idkategori = Int16.Parse(view.cmbKategori.SelectedItem.ToString());
            model.idrak = Int16.Parse(view.cmbRak.SelectedItem.ToString());
            model.satuan = view.txtSatuan.Text;
            model.stock = Int16.Parse(view.txtStock.Text);
            hasil = model.updateBarang();
            return hasil;
        }

        public Boolean deleteBarang()
        {
            model.idbarang = Int16.Parse(view.txtIdBarang.Text);
            hasil = model.deleteBarang();
            return hasil;
        }
        public void setKode()
        {
            view.txtIdBarang.Text = model.maxPK().ToString();
        }
    }
}