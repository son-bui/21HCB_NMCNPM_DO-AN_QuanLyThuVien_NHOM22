import { environment } from 'src/environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

export class SachForCreationDto {
  ten!: string;
  loai!: string;
  tacGia!: string;
  namSx!: string;
  nhaSx!: string;
  tinhTrang!: string;
  gia!: number;
  ngayTiepNhan!: string;
  nhanVienId!: string;
}

@Injectable({
  providedIn: 'root'
})
export class SachService {
  constructor(private http: HttpClient) { }
  
  GetAllSach(pageNum: number, pageSize: number, search: string) {
    return this.http.get(environment.apiUrl + 'sachs/GetAll?PageNumber=' + pageNum + '&PageSize=' + pageSize + '&Search=' + search, {
      headers: new HttpHeaders({ "Content-Type": "application/json" }),
    });
  }

  CreateSach(val: SachForCreationDto) {
    return this.http.post(environment.apiUrl + "sachs/CreateSach", JSON.stringify(val), {
      headers: new HttpHeaders({
        "Content-Type": "application/json",
        'Accept': 'application/json',
      }),
    });
  }

  DeleteSach(id: string) {
    return this.http.delete(environment.apiUrl + "sachs/DeleteSach/" + id, {
      headers: new HttpHeaders({
        "Content-Type": "application/json",
        'Accept': 'application/json',
      }),
    })
  }

  UpdateSach(id: string, val: SachForCreationDto) {
    return this.http.put(environment.apiUrl + "sachs/UpdateSach/" + id, JSON.stringify(val), {
      headers: new HttpHeaders({
        "Content-Type": "application/json",
        'Accept': 'application/json',
      }),
    });
  }
}
