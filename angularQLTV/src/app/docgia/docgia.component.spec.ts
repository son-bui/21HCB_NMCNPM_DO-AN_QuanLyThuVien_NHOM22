/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { DocgiaComponent } from './docgia.component';

describe('DocgiaComponent', () => {
  let component: DocgiaComponent;
  let fixture: ComponentFixture<DocgiaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DocgiaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DocgiaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
