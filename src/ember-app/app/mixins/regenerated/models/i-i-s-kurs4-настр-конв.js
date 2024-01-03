import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  наименование: DS.attr('string'),
  тч_настр: DS.hasMany('i-i-s-kurs4-тч-настр', { inverse: 'настрКонв', async: false })
});

export let ValidationRules = {
  наименование: {
    descriptionKey: 'models.i-i-s-kurs4-настр-конв.validations.наименование.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  тч_настр: {
    descriptionKey: 'models.i-i-s-kurs4-настр-конв.validations.тч_настр.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('НастрКонвE', 'i-i-s-kurs4-настр-конв', {
    наименование: attr('Наименование', { index: 0 }),
    тч_настр: hasMany('i-i-s-kurs4-тч-настр', 'Атрибуты настройки', {
      атрибут: attr('Атрибут', { index: 0 }),
      типАтр: attr('Тип атр', { index: 1 }),
      ограничение: attr('Ограничение', { index: 2 }),
      обязательное: attr('Обязательное', { index: 3 })
    })
  });

  modelClass.defineProjection('НастрКонвL', 'i-i-s-kurs4-настр-конв', {
    наименование: attr('Наименование', { index: 0 })
  });
};
