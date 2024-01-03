import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  атрибут: DS.attr('string'),
  обязательный: DS.attr('boolean'),
  ограничение: DS.attr('number'),
  типАтр: DS.attr('i-i-s-kurs4-тип-атр'),
  загрФайла: DS.belongsTo('i-i-s-kurs4-загр-файла', { inverse: 'тч_загр', async: false })
});

export let ValidationRules = {
  атрибут: {
    descriptionKey: 'models.i-i-s-kurs4-тч-загр.validations.атрибут.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  обязательный: {
    descriptionKey: 'models.i-i-s-kurs4-тч-загр.validations.обязательный.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  ограничение: {
    descriptionKey: 'models.i-i-s-kurs4-тч-загр.validations.ограничение.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  типАтр: {
    descriptionKey: 'models.i-i-s-kurs4-тч-загр.validations.типАтр.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  загрФайла: {
    descriptionKey: 'models.i-i-s-kurs4-тч-загр.validations.загрФайла.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('Тч_загрE', 'i-i-s-kurs4-тч-загр', {
    атрибут: attr('Атрибут', { index: 0 }),
    ограничение: attr('Ограничение', { index: 1 }),
    обязательный: attr('Обязательный', { index: 2 }),
    типАтр: attr('Тип атр', { index: 3 })
  });
};
